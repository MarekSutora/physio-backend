using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class PatientNote
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;

        public int? PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
    }
}
