using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Seeding
{
    public static class ExerciseTypeSeeding
    {
        public static void SeedExerciseTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseType>().HasData(
                    new ExerciseType { Id = 1, Name = "Shoulder Press" },
                    new ExerciseType { Id = 2, Name = "Bench Press" },
                    new ExerciseType { Id = 3, Name = "Squat" },
                    new ExerciseType { Id = 4, Name = "Deadlift" },
                    new ExerciseType { Id = 5, Name = "Pull Up" },
                    new ExerciseType { Id = 6, Name = "Push Up" },
                    new ExerciseType { Id = 7, Name = "Sit Up" },
                    new ExerciseType { Id = 8, Name = "Plank" },
                    new ExerciseType { Id = 9, Name = "Lunges" },
                    new ExerciseType { Id = 10, Name = "Burpees" },
                    new ExerciseType { Id = 11, Name = "Mountain Climbers" },
                    new ExerciseType { Id = 12, Name = "Jumping Jacks" },
                    new ExerciseType { Id = 13, Name = "Squat Jumps" },
                    new ExerciseType { Id = 14, Name = "Box Jumps" },
                    new ExerciseType { Id = 15, Name = "Wall Balls" },
                    new ExerciseType { Id = 16, Name = "Kettlebell Swings" },
                    new ExerciseType { Id = 17, Name = "Thrusters" },
                    new ExerciseType { Id = 18, Name = "Power Cleans" },
                    new ExerciseType { Id = 19, Name = "Snatches" },
                    new ExerciseType { Id = 20, Name = "Clean and Jerk" },
                    new ExerciseType { Id = 21, Name = "Overhead Squat" },
                    new ExerciseType { Id = 22, Name = "Front Squat" },
                    new ExerciseType { Id = 23, Name = "Back Squat" },
                    new ExerciseType { Id = 24, Name = "Sumo Deadlift High Pull" },
                    new ExerciseType { Id = 25, Name = "Turkish Get Up" },
                    new ExerciseType { Id = 26, Name = "Handstand Push Up" },
                    new ExerciseType { Id = 27, Name = "Muscle Up" },
                    new ExerciseType { Id = 28, Name = "Toes to Bar" },
                    new ExerciseType { Id = 29, Name = "Double Unders" },
                    new ExerciseType { Id = 30, Name = "Skipping Rope" }
                    );
        }
    }
}
