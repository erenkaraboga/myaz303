using Microsoft.EntityFrameworkCore;
using myaz303.Models.Mapping;

namespace myaz303.Models.Context
{
    public class MvcDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }


        public MvcDbContext(DbContextOptions<MvcDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderDetailMap());
           
        }
    }
}
