using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class AvailableReservation
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int ReservedAmount { get; set; }
        public DateTime Date { get; set; }

        public List<ActivityType> ActivityTypes { get; } = [];
        public List<AvailableReservationActivityType> AvailableReservationActivityTypes { get; } = [];
        public ICollection<Reservation> Reservations { get; } = new List<Reservation>();
    }
}
