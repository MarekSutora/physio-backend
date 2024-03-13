using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO.ServiceType.Request;

namespace Shared.DTO.ServiceType.Response
{
    public class ServiceTypeDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string HexColor { get; set; }
        public required string IconName { get; set; }
        public required string ImageUrl { get; set; }
        public required List<ServiceTypeDurationCostDto> Stdcs { get; set; }
    }
}
