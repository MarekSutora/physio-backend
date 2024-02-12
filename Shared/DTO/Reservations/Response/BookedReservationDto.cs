using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Reservations.Response
{
    public class BookedReservationDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public string ServiceTypeName { get; set; }
        public string Person { get; set; }
        public decimal Cost { get; set; }
        public string Note { get; set; }
        public string HexColor { get; set; }
    }
}
