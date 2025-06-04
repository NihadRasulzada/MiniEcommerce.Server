using MiniEcommerceServer.Application.DTOs.Configuration;

namespace MiniEcommerceServer.Application.Abstractions.Services.Configurations
{
    public interface IApplicationService
    {
        List<Menu> GetAuthorizeDefinitionEndpoints(Type type);
    }
}
