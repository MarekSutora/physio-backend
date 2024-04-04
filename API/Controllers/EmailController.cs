using Application.Services.Interfaces;
using Application.Utilities.Email;
using Microsoft.AspNetCore.Mvc;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("email")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly ILogger<EmailController> _logger;

        public EmailController(IEmailService emailService, ILogger<EmailController> logger)
        {
            _emailService = emailService;
            _logger = logger;
        }

        [HttpPost("contact-form")]
        public async Task<IActionResult> SendContactFormEmailAsync([FromBody] ContactFormEmailRequest request)
        {
            _logger.LogInformation("Sending contact form email.");
            try
            {
                await _emailService.SendContactFormEmailAsync(request);
                _logger.LogInformation("Contact form email sent.");
                return Ok("Email úspešne odoslaný.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending contact form email.");
                return BadRequest("Pri odosielaní emailu z kontaktného formulára došlo k chybe.");
            }
        }
    }
}
