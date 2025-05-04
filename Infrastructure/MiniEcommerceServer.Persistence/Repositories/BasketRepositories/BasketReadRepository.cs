namespace MiniEcommerceServer.Persistence.Repositories.BasketRepositories
{
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
