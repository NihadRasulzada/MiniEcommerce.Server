﻿using MediatR;
using MiniEcommerceServer.Application.Abstractions.Services;

namespace MiniEcommerceServer.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly IAuthService _authService;
        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.LoginAsync(request.UsernameOrEmail, request.Password, 600);
            return new LoginUserSuccessCommandResponse()
            {
                Token = token
            };
        }
    }
}
