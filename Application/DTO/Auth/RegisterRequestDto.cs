using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Auth
{
    public class RegisterRequestDto
    {
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(256, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 256 characters long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100, ErrorMessage = "First name must not exceed 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100, ErrorMessage = "Last name must not exceed 100 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [StringLength(100, ErrorMessage = "Phone number must be 100 characters long.")]
        public string PhoneNumber { get; set; }
    }
}
