using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Appointments.Request
{
    public class CreateAppointmentDto
    {
        [Required(ErrorMessage = "Attribute StdcIds is required")]
        public List<int> StdcIds { get; set; }
        [Required(ErrorMessage = "Attribute StartTime is required")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "Attribute Capacity is required")]
        public int Capacity { get; set; }
    }
}
