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

        public string? Name { get; set; }

        public string? HexColor { get; set; }

        public string? Description { get; set; }

        public bool Active { get; set; } = true;

        public List<AvailableReservation> AvailableReservations { get; } = [];
        public List<AvailableReservationServiceTypeDc> AvailableReservationServiceTypeDcs { get; } = [];

        public List<DurationCost> DurationCosts { get; } = [];
        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];


        public ICollection<BookedReservation> BookedReservations { get; set; } = new List<BookedReservation>();
    }
}
