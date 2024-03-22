using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Auth
{
    public class RegisterRequestDto
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(256, ErrorMessage = "Password must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(256, ErrorMessage = "First name cannot exceed {1} characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(256, ErrorMessage = "Last name cannot exceed {1} characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [StringLength(10, ErrorMessage = "Phone number must be {1} characters long.")]
        public string PhoneNumber { get; set; }
    }
}
