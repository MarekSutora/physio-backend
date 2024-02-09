using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class ServiceTypeDurationCost
    {
        public int Id { get; set; }
        public int ServiceTypeId { get; set; }
        public int DurationCostId { get; set; }
        public ServiceType ServiceType { get; set; } = null!;
        public DurationCost DurationCost { get; set; } = null!;
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }


        public List<AvailableReservation> AvailableReservations { get; } = [];
        public List<AvailableReservationServiceTypeDc> AvailableReservationServiceTypeDcs { get; } = [];
    }
}
