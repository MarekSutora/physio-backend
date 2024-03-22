using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    public class PersonEntityConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.FirstName)
                .IsRequired().HasMaxLength(100);

            builder.Property(p => p.LastName)
                .IsRequired().HasMaxLength(100);

            builder.Property(p => p.PhoneNumber)
                .IsRequired().HasMaxLength(100);
        }
    }
}
