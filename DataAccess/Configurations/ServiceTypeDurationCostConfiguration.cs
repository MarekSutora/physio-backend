using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    public class ServiceTypeDurationCostConfiguration : IEntityTypeConfiguration<ServiceTypeDurationCost>
    {
        public void Configure(EntityTypeBuilder<ServiceTypeDurationCost> builder)
        {

        }
    }
}
