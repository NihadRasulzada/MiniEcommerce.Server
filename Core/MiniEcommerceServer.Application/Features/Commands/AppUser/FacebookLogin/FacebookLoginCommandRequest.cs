using MediatR;

namespace MiniEcommerceServer.Application.Features.Commands.AppUser.FacebookLogin
{
    public class FacebookLoginCommandRequest : IRequest<FacebookLoginCommandResponse>
    {
        public string AuthToken { get; set; }
    }
}
