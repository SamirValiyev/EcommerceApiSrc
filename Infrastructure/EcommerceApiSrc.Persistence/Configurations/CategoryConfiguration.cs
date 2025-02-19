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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id=1,
                Name="Elektrik",
                Priority=1,
                ParentId=0,
                IsDeleted=false,
                CreatedDate=DateTime.Now,
            };
            Category category2 = new()
            {
                Id=2,
                Name="Trend",
                Priority=2,
                IsDeleted = false,
                ParentId=0,
                CreatedDate=DateTime.Now
            };
            Category category3 = new()
            {
                Id = 3,
                Name = "Komputer",
                Priority = 1,
                IsDeleted = false,
                ParentId = 1,
                CreatedDate = DateTime.Now
            };
            Category category4 = new()
            {
                Id = 4,
                Name = "Qadın",
                Priority = 1,
                ParentId = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };
            builder.HasData(category1, category2, category3, category4);  
        }
    }
}
