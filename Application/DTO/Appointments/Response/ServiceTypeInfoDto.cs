

namespace Application.DTO.Appointments.Response
{
    public class ServiceTypeInfoDto
    {
        public int AstdcId { get; set; }
        public string Name { get; set; }
        public int DurationMinutes { get; set; }
        public decimal Cost { get; set; }
        public string HexColor { get; set; }
    }
}
