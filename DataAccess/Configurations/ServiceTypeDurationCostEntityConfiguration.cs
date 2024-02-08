using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configurations
{
    public class ServiceTypeDurationCostEntityConfiguration : IEntityTypeConfiguration<ServiceTypeDurationCost>
    {
        public void Configure(EntityTypeBuilder<ServiceTypeDurationCost> builder)
        {

        }
    }
}
