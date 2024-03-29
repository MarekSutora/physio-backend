using Application.Common.Email;
using Application.Services.Interfaces;
using Application.Utilities.Email;
using DataAccess;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Application.Services.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;
        private readonly EmailSettings _mailSettings;
        private readonly ApplicationDbContext _context;

        public EmailService(ILogger<EmailService> logger, IOptions<EmailSettings> mailSettings, ApplicationDbContext context)
        {
            _logger = logger;
            _mailSettings = mailSettings.Value;
            _context = context;
        }

        public async Task SendContactFormEmailAsync(ContactFormEmailRequest request)
        {
            var subject = "Kontaktný formulár";
            var body = $"<h1>{request.Name} {request.SecondName}</h1>" +
                        $"<p>Email: {request.Email}</p>" +
                        $"<p>Telefónne číslo: {request.PhoneNumber}</p>" +
                        $"<p>{request.Message}</p>";

            var emailRequest = new EmailRequest
            {
                From = request.Email,
                ToEmail = _mailSettings.SmtpUser,
                Subject = subject,
                Body = body
            };

            await SendEmailAsync(emailRequest);

            var confirmationSubject = "Potvrdenie prijatia správy.";
            var confirmationBody = @"
                    <h1>Ďakujeme za Váš záujem!</h1>
                    <p>Vašu správu sme úspešne prijali a budeme sa Vám snažiť čo najskôr odpovedať.</p>
                    <p>S pozdravom,<br>Váš tím</p>";

            var confirmationEmailRequest = new EmailRequest
            {
                From = _mailSettings.SmtpUser,
                ToEmail = request.Email,
                Subject = confirmationSubject,
                Body = confirmationBody
            };

            await SendEmailAsync(confirmationEmailRequest);
        }


        public async Task SendReminderEmailsAsync()
        {

            var upcomingAppointments = await _context.BookedAppointments
                      .Include(ba => ba.AppointmentServiceTypeDurationCost)
                      .ThenInclude(astdc => astdc.Appointment)
                      .ThenInclude(astdc => astdc.ServiceTypeDurationCosts)
                      .ThenInclude(stdc => stdc.ServiceType)
                      .Include(c => c.Person)
                      .ThenInclude(p => p.ApplicationUser)
                      .Where(ba => !ba.IsFinished && !ba.SevenDaysReminderSent && !ba.OneDayReminderSent)
                      .ToListAsync();

            foreach (var appointment in upcomingAppointments)
            {
                var startTime = appointment.AppointmentServiceTypeDurationCost.Appointment.StartTime;
                var daysToAppointment = (startTime - DateTime.UtcNow).TotalDays;
                var subject = "Pripomienka termínu";
                var serviceName = appointment.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name;
                var appointmentDateTime = appointment.AppointmentServiceTypeDurationCost.Appointment.StartTime.ToString("dd.MM.yyyy HH:mm");

                var body = $"<h1>Blíži sa Váš termín {appointmentDateTime}. Tešíme sa na Vás.</h1>";
                body += $"<p>Objednali ste si službu: {serviceName}.</p>";

                if (!appointment.SevenDaysReminderSent && daysToAppointment <= 7.5 && daysToAppointment > 2.5)
                {
                    await SendEmailAsync(new EmailRequest
                    {
                        ToEmail = appointment.Person.ApplicationUser.Email,
                        Subject = subject,
                        Body = body
                    });

                    appointment.SevenDaysReminderSent = true;
                }

                if (!appointment.OneDayReminderSent && daysToAppointment < 1.5)
                {
                    await SendEmailAsync(new EmailRequest
                    {
                        ToEmail = appointment.Person.ApplicationUser.Email,
                        Subject = subject,
                        Body = body
                    });

                    appointment.OneDayReminderSent = true;
                }

                if (appointment.SevenDaysReminderSent || appointment.OneDayReminderSent)
                {
                    _context.BookedAppointments.Update(appointment);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task SendEmailAsync(EmailRequest emailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(emailRequest.From ?? _mailSettings.SmtpUser);
            email.To.Add(MailboxAddress.Parse(emailRequest.ToEmail));
            email.Subject = emailRequest.Subject;
            var builder = new BodyBuilder();
            builder.HtmlBody = emailRequest.Body;
            email.Body = builder.ToMessageBody();

            using (var smtpCLient = new SmtpClient())
            {
                smtpCLient.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);
                smtpCLient.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPass);
                await smtpCLient.SendAsync(email);
                smtpCLient.Disconnect(true);
            }
        }
    }
}
