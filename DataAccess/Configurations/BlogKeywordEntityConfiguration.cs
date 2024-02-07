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
    public class BlogPostKeywordEntityConfiguration : IEntityTypeConfiguration<BlogPostKeyword>
    {
        public void Configure(EntityTypeBuilder<BlogPostKeyword> builder)
        {
            builder.Property(bpk => bpk.Name).IsRequired().HasMaxLength(100);
        }
    }
}
