namespace MiniEcommerceServer.Persistence.Repositories.CustomerRepositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
