using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configurations
{
    public class BlogPostEntityConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasIndex(st => st.Slug)
                .IsUnique();

            builder.HasIndex(st => st.Title)
                .IsUnique();
        }
    }
}
