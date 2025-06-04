using MiniEcommerceServer.Application.Repositories.Menu;

namespace MiniEcommerceServer.Persistence.Repositories.Menu
{
    public class MenuReadRepository : ReadRepository<Domain.Entities.Menu>, IMenuReadRepository
    {
        public MenuReadRepository(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
