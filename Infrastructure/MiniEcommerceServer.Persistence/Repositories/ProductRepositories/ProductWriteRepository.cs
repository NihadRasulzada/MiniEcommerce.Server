using MiniEcommerceServer.Application.Repositories.ProductRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.ProductRepositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
