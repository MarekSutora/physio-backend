using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.ServiceType
{
    public class ServiceTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HexColor { get; set; }
        public List<ServiceTypeDurationCostDto> ServiceTypeDurationCosts { get; set; }
    }
}
