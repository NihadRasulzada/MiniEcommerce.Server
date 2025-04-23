using MiniEcommerceServer.Application.Repositories.InvoiceFileRepositories;
using MiniEcommerceServer.Domain.Entities;
using MiniEcommerceServer.Persistence.Contexts;

namespace MiniEcommerceServer.Persistence.Repositories.InvoiceFileRepositories
{
    public class InvoiceFileReadRepository : ReadRepository<InvoiceFile>, IInvoiceFileReadRepository
    {
        public InvoiceFileReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
