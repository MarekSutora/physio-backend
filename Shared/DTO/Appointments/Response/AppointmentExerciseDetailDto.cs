using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Appointments.Response
{
    public class AppointmentExerciseDetailDto
    {
        public ExerciseTypeDto ExerciseType { get; set; }
        public decimal Weight { get; set; }
        public int? NumberOfRepetitions { get; set; }
        public int? ExpectedNumberOfSets { get; set; }
        public int? ExpectedDurationInMinutes { get; set; }
        public int? RestAfterExerciseInMinutes { get; set; }
        public int? RestBetweenSetsInMinutes { get; set; }
        public int Order { get; set; }
        public bool SuccessfullyPerformed { get; set; }
    }
}
