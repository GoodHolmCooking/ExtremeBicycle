using Microsoft.EntityFrameworkCore;

namespace ExtremeBicycle.Models.Entities {
    public class ProductsContext : DbContext {

        public ProductsContext(DbContextOptions options) : base(options)
        {
            
        }

        // collections
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Pattern
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
