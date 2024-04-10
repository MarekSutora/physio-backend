using System.ComponentModel.DataAnnotations;

namespace Application.Utilities.Email
{
    public class ContactFormEmailRequest
    {
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        [Required]
        [MinLength(1)]
        public string SecondName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string Message { get; set; }

    }
}
