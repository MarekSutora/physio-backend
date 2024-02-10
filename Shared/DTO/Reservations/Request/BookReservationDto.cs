using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Reservations.Request
{
    public class BookReservationDto
    {
        public int AvailableReservationId { get; set; }
        public bool IsCancelled { get; set; }
        public string? Note { get; set; }
        public int? PatientId { get; set; }
    }
}
