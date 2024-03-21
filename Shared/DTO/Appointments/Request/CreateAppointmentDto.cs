using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Request
{
    public class CreateAppointmentDto
    {
        [Required]
        public List<int> StdcIds { get; set; }

        public DateTime StartTime { get; set; }

        public int Capacity { get; set; }
    }
}
