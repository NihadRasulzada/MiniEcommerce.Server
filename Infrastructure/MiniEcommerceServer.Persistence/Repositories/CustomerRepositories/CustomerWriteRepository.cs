namespace MiniEcommerceServer.Persistence.Repositories.CustomerRepositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
