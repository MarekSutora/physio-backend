using Shared.DTO.Patients.Response;
using Shared.DTO.ServiceType.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Response
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }
        public List<BookedAppointmentDto> BookedAppointments { get; set; } = new List<BookedAppointmentDto>();
        public AppointmentDetailDto AppointmentDetail { get; set; }
    }
}
