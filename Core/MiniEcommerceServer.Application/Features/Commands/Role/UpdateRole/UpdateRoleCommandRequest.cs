﻿using MediatR;

namespace MiniEcommerceServer.Application.Features.Commands.Role.UpdateRole
{
    public class UpdateRoleCommandRequest : IRequest<UpdateRoleCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
