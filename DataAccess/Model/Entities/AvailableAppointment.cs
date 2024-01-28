using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class AvailableAppointment
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int ReservedAmount { get; set; }
        public DateTime Date { get; set; }

        public List<ActivityType> ActivityTypes { get; } = [];
        public List<AvailableAppointmentActivityType> AvailableAppointmentActivityTypes { get; } = [];
        public ICollection<Appointment> Appointments { get; } = new List<Appointment>();
    }
}
