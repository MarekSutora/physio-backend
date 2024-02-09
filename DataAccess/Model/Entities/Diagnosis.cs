using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Severity { get; set; }

        public List<Patient> Patients { get; } = [];
        public List<PatientDiagnosis> PatientDiagnosiss { get; } = [];
    }
}
