using Application.Common.Email;
using Application.Services.Interfaces;
using DataAccess;
using MailKit.Net.Smtp;
using MailKit.Security;
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
                throw new Exception("Error when sending an email", ex);
            }
        }

        public async Task SendReminderEmailsAsync()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("Error when sending reminder emails", ex);
            }
        }
    }
}
