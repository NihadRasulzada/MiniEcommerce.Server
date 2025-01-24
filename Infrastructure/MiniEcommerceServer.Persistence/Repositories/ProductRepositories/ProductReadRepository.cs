using MiniEcommerceServer.Application.Repositories.ProductRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.ProductRepositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
