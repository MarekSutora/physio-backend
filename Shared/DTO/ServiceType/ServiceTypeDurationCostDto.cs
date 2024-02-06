using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.ServiceType
{
    public class ServiceTypeDurationCostDto
    {
        public int Id { get; set; }
        public int DurationMinutes { get; set; }
        public decimal Cost { get; set; }
    }
}
