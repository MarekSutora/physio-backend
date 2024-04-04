using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Auth
{
    public class ForgotPasswordRequestDto
    {
        [Required(ErrorMessage = "Attribute Email is required.")]
        [EmailAddress(ErrorMessage = "Attribute Email must be a valid email address.")]
        public string Email { get; set; }
    }
}
