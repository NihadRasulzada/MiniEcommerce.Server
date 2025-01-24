using MiniEcommerceServer.Application.Repositories.CustomerRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.CustomerRepositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
