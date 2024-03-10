using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Request
{
    public class AdminBookedAppointmentDto
    {
        public int ServiceTypeDurationCostId { get; set; }

        public int? ClientId { get; set; }

        public DateTime StartTime { get; set; }
    }
}
