using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configurations
{
    public class AvailableReservationConfiguration : IEntityTypeConfiguration<AvailableReservation>
    {
        public void Configure(EntityTypeBuilder<AvailableReservation> builder)
        {
            builder.Property(ar => ar.Date)
                .IsRequired().HasColumnType("datetime2"); ;

            builder.Property(ar => ar.Capacity)
                .IsRequired();

            builder.Property(ar => ar.ReservedAmount)
                .IsRequired();
        }
    }
}
