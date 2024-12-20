﻿using System.ComponentModel.DataAnnotations;
using Application.DTO.Appointments.Response;

namespace Application.DTO.Appointments.Both
{
    public class AppointmentExerciseDetailDto
    {
        [Required(ErrorMessage = "Attribute ExerciseType is required.")]
        public ExerciseTypeDto ExerciseType { get; set; }
        public decimal? Weight { get; set; }
        public int? NumberOfRepetitions { get; set; }
        public int? NumberOfSets { get; set; }
        public int? DurationInMinutes { get; set; }
        public int? RestAfterExerciseInMinutes { get; set; }
        public int? RestBetweenSetsInMinutes { get; set; }
        public int? Order { get; set; }
        public bool? SuccessfullyPerformed { get; set; }
    }
}
