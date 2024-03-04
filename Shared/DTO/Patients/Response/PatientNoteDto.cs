using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Patients.Response
{
    public class PatientNoteDto
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
    }
}
