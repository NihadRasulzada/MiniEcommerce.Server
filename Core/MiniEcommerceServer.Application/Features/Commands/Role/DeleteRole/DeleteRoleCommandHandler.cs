﻿using MediatR;
using MiniEcommerceServer.Application.Abstractions.Services;

namespace MiniEcommerceServer.Application.Features.Commands.Role.DeleteRole
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommandRequest, DeleteRoleCommandResponse>
    {
        readonly IRoleService _roleService;

        public DeleteRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _roleService.DeleteRole(request.Id);
            return new()
            {
                Succeeded = result,
            };
        }
    }
}
