using Application.DTO.Appointments.Response;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Appointments.Both
{
    public class AppointmentDto
    {
        [Required(ErrorMessage = "Attribute Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Attribute Capacity is required")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "Attribute StartTime is required")]
        public DateTime StartTime { get; set; }
        public List<BookedAppointmentDto> BookedAppointments { get; set; } = new List<BookedAppointmentDto>();
        public AppointmentDetailDto AppointmentDetail { get; set; }
    }
}
