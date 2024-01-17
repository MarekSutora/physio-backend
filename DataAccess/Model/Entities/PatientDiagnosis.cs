using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class PatientDiagnosis
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;

        public int DiagnosisId { get; set; }
        public Diagnosis Diagnosis { get; set; } = null!;

        public DateTime? Date { get; set; }
    }
}
