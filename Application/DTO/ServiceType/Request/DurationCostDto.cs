﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.ServiceType.Request
{
    public class DurationCostDto
    {
        public int DurationMinutes { get; set; }
        public decimal Cost { get; set; }
    }
}