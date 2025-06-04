using MiniEcommerceServer.Application.Repositories.Endpoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerceServer.Persistence.Repositories.Endpoint
{
    public class EndpointReadRepository : ReadRepository<Domain.Entities.Endpoint>, IEndpointReadRepository
    {
        public EndpointReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
