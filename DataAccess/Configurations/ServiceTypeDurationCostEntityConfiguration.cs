using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ServiceTypeDurationCostEntityConfiguration : IEntityTypeConfiguration<ServiceTypeDurationCost>
    {
        public void Configure(EntityTypeBuilder<ServiceTypeDurationCost> builder)
        {
            builder.Property(st => st.DurationMinutes)
                 .IsRequired();

            builder.Property(st => st.Cost)
                .HasColumnType("money");

            builder.Property(st => st.Active)
                .HasDefaultValue(true);
        }
    }
}
