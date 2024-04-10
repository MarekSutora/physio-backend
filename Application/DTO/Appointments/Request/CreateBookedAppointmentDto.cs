using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Appointments.Request
{
    public class CreateBookedAppointmentDto
    {
        [Required(ErrorMessage = "Attribtute AstdcId is required")]
        public int AstdcId { get; set; }
    }
}

