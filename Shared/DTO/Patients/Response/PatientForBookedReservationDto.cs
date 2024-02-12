using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Patients.Response
{
    public class PatientForBookedReservationDto
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

    }
}
