
using System.ComponentModel.DataAnnotations;


namespace Application.DTO.Auth
{
    public class ResetPasswordRequestDto
    {
        [Required(ErrorMessage = "Attribute Email is required.")]
        [EmailAddress(ErrorMessage = "Attribute Email must be a valid email address.")]
        public string Email { get; set; }
        [Required]
        public string Token { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(256, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 256 characters long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword is required.")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
