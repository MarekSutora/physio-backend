using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {

            builder.HasIndex(bp => bp.Title)
                .IsUnique();

            builder.Property(bp => bp.Title)
                .IsRequired().HasMaxLength(100);

            builder.HasIndex(bp => bp.Slug)
                .IsUnique();

            builder.Property(bp => bp.Slug).HasMaxLength(100);

            builder.Property(bp => bp.Author)
                .IsRequired().HasMaxLength(100);

            builder.Property(bp => bp.DatePublished)
                .IsRequired();

            builder.Property(bp => bp.HTMLContent)
                .IsRequired();

            builder.Property(bp => bp.KeywordsString)
                .IsRequired().HasMaxLength(300);

            builder.Property(bp => bp.MainImageUrl)
                .IsRequired();

            builder.Property(bp => bp.IsHidden)
                .IsRequired();

            builder.Property(bp => bp.ViewCount)
                .IsRequired();
        }
    }
}
