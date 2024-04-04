using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ServiceTypeConfiguration : IEntityTypeConfiguration<ServiceType>
    {
        public void Configure(EntityTypeBuilder<ServiceType> builder)
        {
            builder.Property(st => st.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(st => st.Slug)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasIndex(st => st.Name)
                .IsUnique();

            builder.HasIndex(st => st.Slug)
               .IsUnique();

            builder.Property(st => st.HexColor)
                .HasDefaultValue("#14746F");

            builder.Property(st => st.Description)
                .IsRequired()
                .HasMaxLength(10000);

            builder.Property(st => st.Active)
                .HasDefaultValue(true);

            builder.Property(st => st.IconName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
