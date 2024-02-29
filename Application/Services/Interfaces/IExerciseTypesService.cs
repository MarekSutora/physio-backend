﻿using Shared.DTO.Appointments.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IExerciseTypesService
    {
        Task<IEnumerable<ExerciseTypeDto>> GetAllExerciseTypesAsync();
    }
}