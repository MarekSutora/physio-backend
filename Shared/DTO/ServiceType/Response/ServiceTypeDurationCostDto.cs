
namespace Shared.DTO.ServiceType.Response
{
    public class ServiceTypeDurationCostDto
    {
        public required int Id { get; set; }
        public required int DurationMinutes { get; set; }
        public required decimal Cost { get; set; }
    }
}
