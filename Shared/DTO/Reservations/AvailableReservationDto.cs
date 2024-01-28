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
        public List<ActivityTypeDto> ActivityTypes { get; set; } = new List<ActivityTypeDto>();
    }
}
