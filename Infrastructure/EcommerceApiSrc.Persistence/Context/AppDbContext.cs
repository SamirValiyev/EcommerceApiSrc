using EcommerceApiSrc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Persistence.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options):base(options) 
        {

            
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Detail> Detail { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
