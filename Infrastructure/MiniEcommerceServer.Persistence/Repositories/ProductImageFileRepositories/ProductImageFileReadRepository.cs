namespace MiniEcommerceServer.Persistence.Repositories.ProductImageFileRepositories
{
    public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
