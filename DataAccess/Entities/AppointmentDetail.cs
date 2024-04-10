namespace DataAccess.Entities
{
    public class AppointmentDetail
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;
        public ICollection<AppointmentExerciseDetail> AppointmentExerciseDetails { get; } = new List<AppointmentExerciseDetail>();
        public string Note { get; set; }
    }
}
