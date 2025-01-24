using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPIContext>
    {
        public ECommerceAPIContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerceAPIContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
