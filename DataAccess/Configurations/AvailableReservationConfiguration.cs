using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configurations
{
    public class AvailableReservationConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.Property(ar => ar.StartTime)
                .IsRequired().HasColumnType("datetime2");

            builder.Property(ar => ar.Capacity)
                .IsRequired();

            //builder.Property(ar => ar.ReservedAmount)
            //    .IsRequired();
        }
    }
}
