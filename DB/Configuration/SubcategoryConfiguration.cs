using System;
using Microsoft.EntityFrameworkCore;
using DB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DB.Configuration
{
    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(s => s.Category)
                   .WithMany(c => c.Subcategories)
                   .HasForeignKey(s => s.CategoryId);
        }
    }
}
