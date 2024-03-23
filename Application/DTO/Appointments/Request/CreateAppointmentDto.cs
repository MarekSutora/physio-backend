using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Appointments.Request
{
    public class CreateAppointmentDto
    {
        [Required]
        public List<int> StdcIds { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public int Capacity { get; set; }
    }
}
