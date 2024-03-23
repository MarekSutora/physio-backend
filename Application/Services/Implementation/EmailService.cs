using Application.Common.Email;
using Application.Services.Interfaces;
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

        public async Task SendEmailAsync(EmailRequest emailRequest)
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError("Error when sending an email: {Message}", ex.Message);
                throw new Exception("Error when sending an email", ex);
            }
        }

        public async Task SendReminderEmailsAsync()
        {
            try
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

                    // vygenreuj telo a daj tam aj info o tom appointmente o aky servicetype ide
                    var body = $"<h1>Termín na {appointment.AppointmentServiceTypeDurationCost.Appointment.StartTime} sa blíži. Tešíme sa na Vás.</h1>";
                    body = body + $"<p>Na tento termín máte objednaný servis: {appointment.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name}</p>";

                    if (!appointment.SevenDaysReminderSent && daysToAppointment <= 7.5)
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
            catch (Exception ex)
            {
                _logger.LogError("Error sending reminder emails: {Message}", ex.Message);
                throw;
            }
        }

    }
}
