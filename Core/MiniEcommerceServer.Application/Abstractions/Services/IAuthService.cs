using MiniEcommerceServer.Application.Abstractions.Services.Authentications;

namespace MiniEcommerceServer.Application.Abstractions.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {

    }
}
