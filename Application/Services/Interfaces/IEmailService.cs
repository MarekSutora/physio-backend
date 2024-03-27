using Application.Common.Email;
using Application.Utilities.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendContactFormEmailAsync(ContactFormEmailRequest request);
        Task SendEmailAsync(EmailRequest emailRequest);
        Task SendReminderEmailsAsync();
    }
}
