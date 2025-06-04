using MiniEcommerceServer.Application.Repositories.Menu;

namespace MiniEcommerceServer.Persistence.Repositories.Menu
{
    public class MenuWriteRepository : WriteRepository<Domain.Entities.Menu>, IMenuWriteRepository
    {
        public MenuWriteRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
