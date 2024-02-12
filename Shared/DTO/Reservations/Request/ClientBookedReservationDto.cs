using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Reservations.Request
{
    public class ClientBookedReservationDto
    {
        public int AvailableReservationServiceTypeDCId { get; set; }
        public int? PatientId { get; set; }
    }
}
