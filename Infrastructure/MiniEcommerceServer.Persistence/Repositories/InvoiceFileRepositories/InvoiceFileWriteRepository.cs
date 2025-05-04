namespace MiniEcommerceServer.Persistence.Repositories.InvoiceFileRepositories
{
    public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
