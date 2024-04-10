using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
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
