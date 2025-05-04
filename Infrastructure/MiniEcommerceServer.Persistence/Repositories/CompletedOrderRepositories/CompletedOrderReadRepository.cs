using MiniEcommerceServer.Application.Repositories.CompletedOrderRepositories;

namespace MiniEcommerceServer.Persistence.Repositories.CompletedOrderRepositories
{
    public class CompletedOrderReadRepository : ReadRepository<CompletedOrder>, ICompletedOrderReadRepository
    {
        public CompletedOrderReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
