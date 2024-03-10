using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class ClientNote
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public int? ClientId { get; set; }
        public Client Client { get; set; } = null!;
    }
}
