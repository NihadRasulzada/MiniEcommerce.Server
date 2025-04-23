using MiniEcommerceServer.Application.Repositories.FileRepositories;
using MiniEcommerceServer.Persistence.Contexts;
using File = MiniEcommerceServer.Domain.Entities.File;

namespace MiniEcommerceServer.Persistence.Repositories.FileRepositories
{
    public class FileReadRepositories : ReadRepository<File>, IFileReadRepository
    {
        public FileReadRepositories(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
