namespace MiniEcommerceServer.Persistence.Repositories.BasketRepositories
{
    public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
