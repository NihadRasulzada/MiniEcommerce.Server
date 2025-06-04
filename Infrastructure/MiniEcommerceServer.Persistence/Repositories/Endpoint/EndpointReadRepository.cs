using MiniEcommerceServer.Application.Repositories.Endpoint;

namespace MiniEcommerceServer.Persistence.Repositories.Endpoint
{
    public class EndpointReadRepository : ReadRepository<Domain.Entities.Endpoint>, IEndpointReadRepository
    {
        public EndpointReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
