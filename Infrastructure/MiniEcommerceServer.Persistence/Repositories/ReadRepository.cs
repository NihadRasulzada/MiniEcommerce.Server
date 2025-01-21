using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MiniEcommerceServer.Application.Repositories;
using MiniEcommerceServer.Domain.Entities.Common;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIContext _context;
        public ReadRepository(ECommerceAPIContext context) => _context = context;

        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll() => Table;
        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
    }
}
