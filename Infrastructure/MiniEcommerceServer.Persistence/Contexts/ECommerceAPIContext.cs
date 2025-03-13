using Microsoft.EntityFrameworkCore;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Domain.Entities.Common;

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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow.AddHours(4),
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow.AddHours(4)
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
