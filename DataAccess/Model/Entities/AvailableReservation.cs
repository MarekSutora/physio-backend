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
        public DateTime StartTime { get; set; }

        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];
        public List<AvailableReservationServiceTypeDc> AvailableReservationServiceTypeDcs { get; } = [];


        public ICollection<BookedReservation> BookedReservations { get; } = new List<BookedReservation>();
    }
}
