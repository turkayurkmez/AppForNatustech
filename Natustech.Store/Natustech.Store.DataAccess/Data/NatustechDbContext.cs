using Microsoft.EntityFrameworkCore;
using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natustech.Store.DataAccess.Data
{
   public class NatustechDbContext : DbContext
    {
        public NatustechDbContext(DbContextOptions<NatustechDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //sadece db'ye özel:
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Product>().HasOne(x => x.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId);




                                          

        }
      
    }
}
