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
        public int? NumberOfRepetitions { get; set; }
        public int? ExpectedNumberOfSets { get; set; }
        public int? ExpectedDurationInMinutes { get; set; }
        public int? RestAfterExerciseInMinutes { get; set; }
        public int? RestBetweenSetsInMinutes { get; set; }
        public int Order { get; set; }
        public bool SuccessfulyPerformed { get; set; } = false;
    }
}
