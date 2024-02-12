using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ServiceTypeEntityConfiguration : IEntityTypeConfiguration<ServiceType>
    {
        public void Configure(EntityTypeBuilder<ServiceType> builder)
        {
            builder.Property(st => st.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasIndex(st => st.Name)
                .IsUnique();

            builder.Property(st => st.HexColor)
                .HasDefaultValue("#14746F");

            builder.Property(st => st.Description)
                .HasMaxLength(1000);

            builder.Property(st => st.Active)
                .HasDefaultValue(true);
        }
    }
}
