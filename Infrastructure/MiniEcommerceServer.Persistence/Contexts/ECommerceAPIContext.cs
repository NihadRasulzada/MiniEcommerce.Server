using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Domain.Entities.Common;
using File = MiniEcommerceServer.Domain.Entities.File;

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

        public DbSet<File> Files { get; set; }
        public DbSet<ProductImageFile> ProductImageFiles { get; set; }
        public DbSet<InvoiceFile> InvoiceFiles { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<EntityEntry<BaseEntity>> datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow.AddHours(4),
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow.AddHours(4),
                    _ => DateTime.UtcNow.AddHours(4),
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
