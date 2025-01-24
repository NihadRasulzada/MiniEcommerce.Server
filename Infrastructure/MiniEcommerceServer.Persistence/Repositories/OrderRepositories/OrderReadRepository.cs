using MiniEcommerceServer.Application.Repositories.OrderRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.OrderRepositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
