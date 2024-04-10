using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Appointments.Both
{
    public class AppointmentDetailDto
    {
        [Required(ErrorMessage = "Attribute Note is required.")]
        [StringLength(10000, ErrorMessage = "Attribute Note must be less than or equal to 10000 characters.")]
        public string Note { get; set; }

        [Required(ErrorMessage = "Attribute AppointmentExerciseDetails is required.")]
        public List<AppointmentExerciseDetailDto> AppointmentExerciseDetails { get; set; } = new List<AppointmentExerciseDetailDto>();
    }
}
