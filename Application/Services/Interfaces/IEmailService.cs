using Application.Common.Email;
using Application.Utilities.Email;

namespace Application.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendContactFormEmailAsync(ContactFormEmailRequest request);
        Task SendEmailAsync(EmailRequest emailRequest);
        Task SendReminderEmailsAsync();
    }
}
