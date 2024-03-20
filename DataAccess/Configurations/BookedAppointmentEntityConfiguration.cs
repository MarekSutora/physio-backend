using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    internal class BookedAppointmentEntityConfiguration : IEntityTypeConfiguration<BookedAppointment>
    {
        public void Configure(EntityTypeBuilder<BookedAppointment> builder)
        {

            builder.Property(br => br.AppointmentBookedDate)
                .HasColumnType("datetime2");
        }
    }
}