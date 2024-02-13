using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    internal class BookedAppointmentEntityConfiguration : IEntityTypeConfiguration<BookedAppointment>
    {
        public void Configure(EntityTypeBuilder<BookedAppointment> builder)
        {
            builder.Property(br => br.IsCancelled)
           .HasDefaultValue(false);

            builder.Property(br => br.AppointmentBookedDate)
                .HasColumnType("datetime2");

            builder.Property(br => br.AppointmentFinishedDate)
                .HasColumnType("datetime2");

            //builder.Property(br => br.Note)
            //    .HasMaxLength(500)
            //    .IsRequired(false);
        }
    }
}