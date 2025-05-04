using MiniEcommerceServer.Application.Repositories;
using MiniEcommerceServer.Application.Repositories.CompletedOrderRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerceServer.Persistence.Repositories.CompletedOrderRepositories
{
    public class CompletedOrderWriteRepository : WriteRepository<CompletedOrder>, ICompletedOrderWriteRepository
    {
        public CompletedOrderWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
