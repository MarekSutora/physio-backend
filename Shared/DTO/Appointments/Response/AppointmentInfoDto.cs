using Shared.DTO.Patients.Response;
using Shared.DTO.ServiceType.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Response
{
    public class AppointmentInfoDto
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }
        public List<BookedAppointmentDto> BookedAppointmentDtos { get; set; } = new List<BookedAppointmentDto>();
        public List<AppointmentDetailDto> AppointmentDetailDtos { get; set; } = new List<AppointmentDetailDto>();

    }
}
