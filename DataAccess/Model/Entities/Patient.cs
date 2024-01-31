﻿using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Patient
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        public List<Diagnosis> Diagnosiss { get; } = [];
        public List<PatientDiagnosis> PatientDiagnosiss { get; } = [];
    }
}
