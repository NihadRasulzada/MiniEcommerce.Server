using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MiniEcommerceServer.Application.Repositories;
using MiniEcommerceServer.Domain.Entities.Common;

namespace MiniEcommerceServer.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIContext _context;
        public WriteRepository(ECommerceAPIContext context) => _context = context;

        public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }
        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return datas.All(m => _context.Entry(m).State == EntityState.Added);
        }
        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }
        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model);
        }
        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return datas.All(m => _context.Entry(m).State == EntityState.Deleted);
        }
        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();
        public bool Update(T model)
        {
            EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
