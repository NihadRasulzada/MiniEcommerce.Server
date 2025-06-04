using MiniEcommerceServer.Application.Repositories.Endpoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerceServer.Persistence.Repositories.Endpoint
{
    public class EndpointWriteRepository : WriteRepository<Domain.Entities.Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
