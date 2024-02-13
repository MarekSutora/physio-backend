using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Request
{
    public class CreateAppointmentDto
    {
        public required List<int> StdcIds { get; set; }

        public required DateTime StartTime { get; set; }

        public required int Capacity { get; set; }
    }
}
