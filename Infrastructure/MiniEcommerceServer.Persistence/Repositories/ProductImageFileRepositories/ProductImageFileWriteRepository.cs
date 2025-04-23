using MiniEcommerceServer.Application.Repositories.ProductImageFileRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.ProductImageFileRepositories
{
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
