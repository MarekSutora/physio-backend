using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }

        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];
        public List<AppointmentServiceTypeDurationCost> AppointmentServiceTypeDurationCosts { get; } = [];

        public AppointmentDetail? AppointmentDetail { get; set; }
    }
}
