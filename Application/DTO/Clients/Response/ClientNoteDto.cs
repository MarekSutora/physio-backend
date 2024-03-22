using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Clients.Response
{
    public class ClientNoteDto
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
