using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniEcommerceServer.Domain.Entities;

namespace MiniEcommerceServer.Application.Repositories.InvoiceFileRepositories
{
    public interface IInvoiceFileWriteRepository : IWriteRepository<InvoiceFile>
    {
    }
}
