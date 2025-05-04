namespace MiniEcommerceServer.Persistence.Repositories.ProductRepositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
