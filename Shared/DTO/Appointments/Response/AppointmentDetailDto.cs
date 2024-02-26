﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Response
{
    public class AppointmentDetailDto
    {
        public string Notes { get; set; }
        public List<AppointmentExerciseDetailDto> appointmentExerciseDetailDtos { get; set; } = new List<AppointmentExerciseDetailDto>();
    }
}
