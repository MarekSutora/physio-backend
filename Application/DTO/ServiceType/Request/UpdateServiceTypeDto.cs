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
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string HexColor { get; set; }
        [Required]
        public List<DurationCostDto> DurationCosts { get; set; }
        [Required]
        public string IconName { get; set; }
        [Required]
        public string ImageUrl { get; set; }

    }
}
