using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeCreated { get; set; }


        public ICollection<Reservation> Reservations { get; } = new List<Reservation>();
    }
}
