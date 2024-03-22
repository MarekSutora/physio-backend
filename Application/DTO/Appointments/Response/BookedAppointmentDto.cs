using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Appointments.Response
{
    public class BookedAppointmentDto
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationMinutes { get; set; }
        public string ServiceTypeName { get; set; }
        public int ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientSecondName { get; set; }
        public decimal Cost { get; set; }
        public string HexColor { get; set; }
        public int Capacity { get; set; }
        public DateTime AppointmentBookedDate { get; set; }
    }
}
