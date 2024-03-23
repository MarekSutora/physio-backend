

namespace Application.DTO.ServiceType.Response
{
    public class ServiceTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HexColor { get; set; }
        public string IconName { get; set; }
        public string ImageUrl { get; set; }
        public List<ServiceTypeDurationCostDto> Stdcs { get; set; }
        public string Slug { get; set; }
    }
}
