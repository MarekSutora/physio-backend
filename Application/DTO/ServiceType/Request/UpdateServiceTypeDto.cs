using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.ServiceType.Request
{
    public class UpdateServiceTypeDto
    {
        [Required(ErrorMessage = "Attribute Id is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Attribute Name is required.")]
        [StringLength(150, ErrorMessage = "Attribute Name must be less than or equal to 150 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Attribute Description is required.")]
        [StringLength(10000, ErrorMessage = "Attribute Description must be less than or equal to 10000 characters.")]
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
