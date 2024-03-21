using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Client
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        public ICollection<ClientNote> ClientNotes { get; } = [];
        public ICollection<BookedAppointment> BookedAppointments { get; } = [];
    }
}
