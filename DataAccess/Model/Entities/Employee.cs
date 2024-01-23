using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public DateTime StartedWorkingDate { get; set; }
        public DateTime? EndedWorkingDate { get; set; }
        public decimal Salary { get; set; }

        public Guid? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
