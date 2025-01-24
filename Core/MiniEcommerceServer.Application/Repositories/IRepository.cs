using Microsoft.EntityFrameworkCore;
using MiniEcommerceServer.Domain.Entities.Common;

namespace MiniEcommerceServer.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
