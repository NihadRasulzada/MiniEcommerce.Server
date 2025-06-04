using MiniEcommerceServer.Application.Repositories.CompletedOrderRepositories;

namespace MiniEcommerceServer.Persistence.Repositories.CompletedOrderRepositories
{
    public class CompletedOrderWriteRepository : WriteRepository<CompletedOrder>, ICompletedOrderWriteRepository
    {
        public CompletedOrderWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
