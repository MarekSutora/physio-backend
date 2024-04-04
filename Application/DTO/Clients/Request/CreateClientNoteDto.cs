﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Clients.Request
{
    public class CreateClientNoteDto
    {
        [Required(ErrorMessage = "Attribute PersonId is required.")]
        public int PersonId { get; set; }
        [Required(ErrorMessage = "Attribute Note is required.")]
        [StringLength(10000, ErrorMessage = "Note must be less than or equal to 500 characters.")]
        public string Note { get; set; }
    }
}
