using EcommerceApiSrc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Persistence.Configurations
{
    public class CategoryProductConfiguration : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
           
            builder.HasOne(x => x.Product)
                   .WithMany(pc => pc.CategoryProduct)
                   .HasForeignKey(p => p.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(x=>x.Category)
                   .WithMany(pc=>pc.CategoryProduct)
                   .HasForeignKey(c=>c.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
