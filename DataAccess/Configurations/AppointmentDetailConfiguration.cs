using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class AppointmentDetailConfiguration : IEntityTypeConfiguration<AppointmentDetail>
    {
        public void Configure(EntityTypeBuilder<AppointmentDetail> builder)
        {
            builder.Property(ad => ad.Note)
                    .IsRequired().HasMaxLength(10000);

            builder.HasIndex(ad => ad.AppointmentId)
                .IsUnique();
        }
    }
}
