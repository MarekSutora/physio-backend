using System.ComponentModel.DataAnnotations;

namespace Application.DTO.ServiceType.Request
{
    public class DurationCostDto
    {
        [Required(ErrorMessage = "Attribute DurationMinutes is required.")]
        public int DurationMinutes { get; set; }

        [Required(ErrorMessage = "Attribute Cost is required.")]
        public decimal Cost { get; set; }
    }
}