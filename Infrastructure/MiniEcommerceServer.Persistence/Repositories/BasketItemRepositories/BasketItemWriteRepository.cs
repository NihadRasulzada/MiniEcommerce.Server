namespace MiniEcommerceServer.Persistence.Repositories.BasketItemRepositories
{
    public class BasketItemWriteRepository : WriteRepository<BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
