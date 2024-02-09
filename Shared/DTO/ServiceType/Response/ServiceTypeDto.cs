using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.ServiceType.Response
{
    public class ServiceTypeDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string HexColor { get; set; }
        public required List<DurationCostDto> DurationCosts { get; set; }
    }
}
