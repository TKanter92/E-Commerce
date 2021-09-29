using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());

            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = 1, ProductName = "Abbey Road", Price = 20, Description = "Cool Album", Genre = "Rock", Rating = 5 }
                );

            modelBuilder.Entity<ShoppingCart>().HasData(
                     new ShoppingCart { ShoppingCartId = 1, Quantity = 2, ProductId = 1, UserId = "3c82f367-c83e-4231-86e3-1775cb1c097a" }
                 );


        }

    }
}
