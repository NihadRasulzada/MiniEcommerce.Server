﻿using MediatR;
using MiniEcommerceServer.Application.Abstractions.Services;

namespace MiniEcommerceServer.Application.Features.Commands.AppUser.VerifyResetToken
{
    public class VerifyResetTokenCommandHandler : IRequestHandler<VerifyResetTokenCommandRequest, VerifyResetTokenCommandResponse>
    {
        readonly IAuthService _authService;

        public VerifyResetTokenCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<VerifyResetTokenCommandResponse> Handle(VerifyResetTokenCommandRequest request, CancellationToken cancellationToken)
        {
            bool state = await _authService.VerifyResetTokenAsync(request.ResetToken, request.UserId);
            return new()
            {
                State = state
            };
        }
    }
}
