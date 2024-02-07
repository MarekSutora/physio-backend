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
    internal class BookedReservationEntityConfiguration : IEntityTypeConfiguration<BookedReservation>
    {
        public void Configure(EntityTypeBuilder<BookedReservation> builder)
        {
            builder.Property(br => br.IsCancelled)
           .HasDefaultValue(false);

            builder.Property(br => br.ReservationBookedDate)
                .HasColumnType("datetime2");

            builder.Property(br => br.ReservationFinishedDate)
                .HasColumnType("datetime2");

            builder.Property(br => br.Note)
                .HasMaxLength(500)
                .IsRequired(false);
        }
    }
}