﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Patients.Response
{
    public class PatientDto
    {
        public int PersonId { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}