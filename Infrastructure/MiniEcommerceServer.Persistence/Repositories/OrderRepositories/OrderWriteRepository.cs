using MiniEcommerceServer.Application.Repositories.OrderRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.OrderRepositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
