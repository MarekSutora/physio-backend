using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Response
{
    public class UnbookedAppointmentDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int Capacity { get; set; }
        public int ReservedCount { get; set; }
        public List<ServiceTypeInfoDto> ServiceTypeInfos { get; set; }
    }
}
