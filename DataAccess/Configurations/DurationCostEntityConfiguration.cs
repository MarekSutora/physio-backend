using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class DurationCostEntityConfiguration : IEntityTypeConfiguration<DurationCost>
    {
        public void Configure(EntityTypeBuilder<DurationCost> builder)
        {
            builder.Property(st => st.DurationMinutes)
                 .IsRequired();

            builder.Property(st => st.Cost)
                .HasColumnType("money");
        }
    }
}
