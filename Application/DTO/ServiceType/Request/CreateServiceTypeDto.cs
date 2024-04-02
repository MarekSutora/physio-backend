﻿using System.ComponentModel.DataAnnotations;

namespace Application.DTO.ServiceType.Request
{
    public class CreateServiceTypeDto
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 7)]
        public string HexColor { get; set; }
        [Required]
        public List<DurationCostDto> DurationCosts { get; set; }
        [Required]
        public string IconName { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
