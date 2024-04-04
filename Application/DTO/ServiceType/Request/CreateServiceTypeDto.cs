using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.ServiceType.Request
{
    public class CreateServiceTypeDto
    {
        [Required(ErrorMessage = "Attribute Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Attribute Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Attribute Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Attribute HexColor is required.")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "Attribute HexColor must be exactly 7 characters.")]
        public string HexColor { get; set; }

        [Required(ErrorMessage = "Attribute DurationCosts is required.")]
        public List<DurationCostDto> DurationCosts { get; set; }

        [Required(ErrorMessage = "Attribute IconName is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Attribute IconName must be between 3 and 50 characters.")]
        public string IconName { get; set; }

        [Required(ErrorMessage = "Attribute ImageUrl is required.")]
        public string ImageUrl { get; set; }
    }
}
