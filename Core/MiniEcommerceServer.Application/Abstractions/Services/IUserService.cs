using MiniEcommerceServer.Application.DTOs.User;
using MiniEcommerceServer.Domain.Entities.Identity;

namespace MiniEcommerceServer.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task UpdateRefreshToken(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    }
}
