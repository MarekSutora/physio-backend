using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class AppointmentExerciseDetail
    {
        public int Id { get; set; }
        public int ExerciseTypeId { get; set; }
        public ExerciseType ExerciseType { get; set; } = null!;
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;
        public int? PlannedNumberOfRepetitions { get; set; }
        public int? PlannedExpectedNumberOfSets { get; set; }
        public int? PlannedExpectedDurationInMinutes { get; set; }
        public int? PlannedRestAfterExerciseInMinutes { get; set; }
        public int? PlannedRestBetweenSetsInMinutes { get; set; }
        public int? ActualNumberOfRepetitions { get; set; }
        public int? ActualNumberOfSets { get; set; }
        public int? ActualDurationInMinutes { get; set; }
        public int? ActualRestAfterExerciseInMinutes { get; set; }
        public int? ActualRestBetweenSetsInMinutes { get; set; }
        public int Order { get; set; }
    }
}
