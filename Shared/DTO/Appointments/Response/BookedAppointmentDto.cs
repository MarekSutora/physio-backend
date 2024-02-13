using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Response
{
    public class BookedAppointmentDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public string ServiceTypeName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientSecondName { get; set; }
        public decimal Cost { get; set; }
        public string HexColor { get; set; }
    }
}
