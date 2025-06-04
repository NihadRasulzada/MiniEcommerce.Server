using MiniEcommerceServer.Application.Repositories.Endpoint;

namespace MiniEcommerceServer.Persistence.Repositories.Endpoint
{
    public class EndpointWriteRepository : WriteRepository<Domain.Entities.Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
