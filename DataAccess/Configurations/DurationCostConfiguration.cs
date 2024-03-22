using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class DurationCostConfiguration : IEntityTypeConfiguration<DurationCost>
    {
        public void Configure(EntityTypeBuilder<DurationCost> builder)
        {
            builder.Property(st => st.DurationMinutes)
                 .IsRequired();

            builder.Property(st => st.Cost).IsRequired()
                .HasColumnType("money");
        }
    }
}
