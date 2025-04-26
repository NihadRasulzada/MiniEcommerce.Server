using MiniEcommerceServer.Domain.Entities.Identity;

namespace MiniEcommerceServer.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        DTOs.Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
