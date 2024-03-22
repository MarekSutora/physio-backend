using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ClientNoteConfiguration : IEntityTypeConfiguration<ClientNote>
    {
        public void Configure(EntityTypeBuilder<ClientNote> builder)
        {
            builder.Property(cn => cn.Note)
                .IsRequired().HasMaxLength(10000);

            builder.Property(cn => cn.CreatedAt)
                .IsRequired();
        }
    }
}
