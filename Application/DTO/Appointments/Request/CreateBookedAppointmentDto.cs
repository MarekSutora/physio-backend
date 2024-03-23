

using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Appointments.Request
{
    public class CreateBookedAppointmentDto
    {
        [Required]
        public int astdcId { get; set; }
    }
}

