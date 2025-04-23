using MiniEcommerceServer.Domain.Entities;
using File = MiniEcommerceServer.Domain.Entities.File;

namespace MiniEcommerceServer.Application.Repositories.FileRepositories
{
    public interface IFileWriteRepository : IWriteRepository<File>
    {
    }
}
