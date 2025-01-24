using Microsoft.EntityFrameworkCore;
using MiniEcommerceServer.Domain.Entities;

namespace MiniEcommerceServer.Persistence.Contexts
{
    public class ECommerceAPIContext : DbContext
    {
        public ECommerceAPIContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
