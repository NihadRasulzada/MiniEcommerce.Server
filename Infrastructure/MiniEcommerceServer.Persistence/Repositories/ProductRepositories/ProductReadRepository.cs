namespace MiniEcommerceServer.Persistence.Repositories.ProductRepositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
