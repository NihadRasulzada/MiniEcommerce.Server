using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniEcommerceServer.Application.Abstractions.Services.Configurations;

namespace MiniEcommerceServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class ApplicationServicesController : ControllerBase
    {
        readonly IApplicationService _applicationService;

        public ApplicationServicesController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        [AuthorizeDefinition(Definition = "Get Authorize Definition Endpints", ActionType = ActionType.Reading, Menu = "Application Services")]
        public IActionResult GetAuthorizeDefinitionEndpints()
        {
            var result = _applicationService.GetAuthorizeDefinitionEndpoints(typeof(Program));
            return Ok(result);
        }
    }
}
