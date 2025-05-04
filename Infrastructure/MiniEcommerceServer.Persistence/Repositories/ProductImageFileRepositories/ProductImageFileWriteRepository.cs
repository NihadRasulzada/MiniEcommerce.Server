namespace MiniEcommerceServer.Persistence.Repositories.ProductImageFileRepositories
{
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
