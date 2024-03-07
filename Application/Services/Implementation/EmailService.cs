using Application.Common.Email;
using Application.Services.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;
        private readonly EmailSettings _mailSettings;

        public EmailService(ILogger<EmailService> logger, IOptions<EmailSettings> mailSettings)
        {
            _logger = logger;
            _mailSettings = mailSettings.Value;
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
                _logger.LogError(ex.Message, ex);
                throw new Exception(ex.Message);
            }
        }
    }
}
