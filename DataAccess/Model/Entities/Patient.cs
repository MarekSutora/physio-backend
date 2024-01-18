using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public List<Diagnosis> Diagnosiss { get; } = [];

        public int? PersonId { get; set; }
        public Person Person { get; set; }
    }
}
