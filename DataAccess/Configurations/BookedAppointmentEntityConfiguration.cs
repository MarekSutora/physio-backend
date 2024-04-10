using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    internal class BookedAppointmentEntityConfiguration : IEntityTypeConfiguration<BookedAppointment>
    {
        public void Configure(EntityTypeBuilder<BookedAppointment> builder)
        {

            builder.Property(ba => ba.AppointmentBookedDate)
                .IsRequired();

            builder.Property(ba => ba.IsFinished)
                .IsRequired();

            builder.Property(ba => ba.SevenDaysReminderSent)
                .IsRequired();

            builder.Property(ba => ba.OneDayReminderSent)
                .IsRequired();
        }
    }
}