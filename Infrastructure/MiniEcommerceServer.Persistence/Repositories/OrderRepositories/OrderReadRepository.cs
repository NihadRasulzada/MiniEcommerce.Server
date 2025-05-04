namespace MiniEcommerceServer.Persistence.Repositories.OrderRepositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
