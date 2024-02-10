using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Reservations.Response
{
    public class ServiceTypeWithCostDto
    {
        public required int arstdcId { get; set; } // AvailableReservationServiceTypeDc ID
        public required string ServiceTypeName { get; set; }
        public required int DurationMinutes { get; set; }
        public required decimal Cost { get; set; }
        public required string HexColor { get; set; }
    }
}
