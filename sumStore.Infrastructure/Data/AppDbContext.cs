using Microsoft.EntityFrameworkCore;
using sumStore.Domain.Entities;

namespace sumStore.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
