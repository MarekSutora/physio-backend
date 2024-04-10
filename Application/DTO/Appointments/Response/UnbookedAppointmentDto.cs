

namespace Application.DTO.Appointments.Response
{
    public class UnbookedAppointmentDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int Capacity { get; set; }
        public int ReservedCount { get; set; }
        public List<ServiceTypeInfoDto> ServiceTypeInfos { get; set; }
    }
}
