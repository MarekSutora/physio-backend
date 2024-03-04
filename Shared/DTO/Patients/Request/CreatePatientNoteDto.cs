using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Patients.Request
{
    public class CreatePatientNoteDto
    {
        public int PatientId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
