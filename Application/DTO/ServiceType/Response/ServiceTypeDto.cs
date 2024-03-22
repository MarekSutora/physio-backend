

namespace Application.DTO.ServiceType.Response
{
    public class ServiceTypeDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string HexColor { get; set; }
        public required string IconName { get; set; }
        public required string ImageUrl { get; set; }
        public required List<ServiceTypeDurationCostDto> Stdcs { get; set; }
        public required string Slug { get; set; }
    }
}
