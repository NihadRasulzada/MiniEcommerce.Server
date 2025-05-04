using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiniEcommerceServer.Application.Abstractions.Services;
using MiniEcommerceServer.Application.Features.Commands.AppUser.CreateUser;

namespace MiniEcommerceServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;
        readonly IMailService _mailService;
        public UsersController(IMediator mediator, IMailService mailService)
        {
            _mediator = mediator;
            _mailService = mailService;
        }

        [HttpGet]
        public async Task<IActionResult> ExampleMailTest()
        {
            await _mailService.SendMessageAsync("", "", "<strong></strong>");
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }
    }
}
