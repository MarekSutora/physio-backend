using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Clients.Request
{
    public class CreateClientNoteDto
    {
        public int PersonId { get; set; }
        public string Note { get; set; }
    }
}
