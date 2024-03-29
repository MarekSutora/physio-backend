using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Auth
{
    public class RegisterRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(256, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(256)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(256)]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
    }
}
