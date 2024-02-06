using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        //TODO unique
        public string Name { get; set; }

        public string HexColor { get; set; }

        public string Description { get; set; }


        public List<AvailableReservation> AvailableReservations { get; } = [];
        public List<AvailableReservationServiceType> AvailableReservationServiceTypes { get; } = [];


        public ICollection<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; set; } = new List<ServiceTypeDurationCost>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
