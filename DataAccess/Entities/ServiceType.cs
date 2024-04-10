namespace DataAccess.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string HexColor { get; set; }

        public required string Description { get; set; }

        public bool Active { get; set; } = true;

        public List<DurationCost> DurationCosts { get; } = [];

        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];

        public required string IconName { get; set; }

        public required string ImageUrl { get; set; }

        public required string Slug { get; set; }
    }
}
