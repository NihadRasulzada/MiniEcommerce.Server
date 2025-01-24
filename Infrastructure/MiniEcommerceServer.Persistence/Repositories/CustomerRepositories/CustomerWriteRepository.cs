using MiniEcommerceServer.Application.Repositories.CustomerRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.CustomerRepositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
