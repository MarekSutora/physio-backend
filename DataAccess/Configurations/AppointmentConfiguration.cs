using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.Property(ar => ar.StartTime)
                .IsRequired().HasColumnType("datetime2");

            builder.Property(ar => ar.Capacity)
                .IsRequired();
        }
    }
}
