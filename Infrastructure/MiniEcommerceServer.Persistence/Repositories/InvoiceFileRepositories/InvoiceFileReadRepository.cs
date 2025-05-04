namespace MiniEcommerceServer.Persistence.Repositories.InvoiceFileRepositories
{
    public class InvoiceFileReadRepository : ReadRepository<InvoiceFile>, IInvoiceFileReadRepository
    {
        public InvoiceFileReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
