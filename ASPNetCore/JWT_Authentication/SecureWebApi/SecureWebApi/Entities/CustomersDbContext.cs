using Microsoft.EntityFrameworkCore;

namespace SecureWebApi.Entities
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Order> Orders { get; set;}

        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            //base.OnModelCreating(modelBuilder);
        }
    }
}
