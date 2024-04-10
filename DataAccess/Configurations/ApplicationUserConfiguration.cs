using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(ar => ar.RefreshToken)
                .HasMaxLength(500);

            builder.Property(ar => ar.RefreshTokenExpiryTime)
                .IsRequired();

            builder.Property(ar => ar.RegisteredDate)
                .IsRequired();
        }
    }

}
