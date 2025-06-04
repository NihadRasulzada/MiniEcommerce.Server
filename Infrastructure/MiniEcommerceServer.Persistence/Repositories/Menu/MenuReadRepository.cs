using MiniEcommerceServer.Application.Repositories.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerceServer.Persistence.Repositories.Menu
{
    public class MenuReadRepository : ReadRepository<Domain.Entities.Menu>, IMenuReadRepository
    {
        public MenuReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
