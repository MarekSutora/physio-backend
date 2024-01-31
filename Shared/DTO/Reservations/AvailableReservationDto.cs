using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Reservations
{
    public class AvailableReservationDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public int ReservedAmount { get; set; }
        public List<ServiceTypeDto> ServiceTypes { get; set; } = new List<ServiceTypeDto>();
    }
}
