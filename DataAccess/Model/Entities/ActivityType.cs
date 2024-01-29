using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int Duration { get; set; }
        public string HexColor { get; set; }

        public List<AvailableReservation> AvailableReservations { get; } = [];
        public List<AvailableReservationActivityType> AvailableReservationActivityTypes { get; } = [];

        public ICollection<Reservation> Reservations { get; } = new List<Reservation>();
    }
}
