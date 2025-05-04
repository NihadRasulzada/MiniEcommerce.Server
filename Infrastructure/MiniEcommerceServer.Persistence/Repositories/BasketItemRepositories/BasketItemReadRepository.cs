namespace MiniEcommerceServer.Persistence.Repositories.BasketItemRepositories
{
    public class BasketItemReadRepository : ReadRepository<BasketItem>, IBasketItemReadRepository
    {
        public BasketItemReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
