using MiniEcommerceServer.Application.Repositories.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerceServer.Persistence.Repositories.Menu
{
    public class MenuWriteRepository : WriteRepository<Domain.Entities.Menu>, IMenuWriteRepository
    {
        public MenuWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
