using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Reservations.Request
{
    public class AdminBookedReservationDto
    {
        public int ServiceTypeDurationCostId { get; set; }

        public int? PatientId { get; set; }

        public DateTime StartTime { get; set; }
    }
}
