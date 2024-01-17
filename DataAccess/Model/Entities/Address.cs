using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string TempAddress { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; } = new List<ApplicationUser>();
    }
}
