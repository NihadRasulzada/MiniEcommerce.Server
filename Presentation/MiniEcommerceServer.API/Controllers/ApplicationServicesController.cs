using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniEcommerceServer.Application.Abstractions.Services.Configurations;

namespace MiniEcommerceServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationServicesController : ControllerBase
    {
        readonly IApplicationService _applicationService;

        public ApplicationServicesController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult GetAuthorizeDefinitionEndpints()
        {
            var result = _applicationService.GetAuthorizeDefinitionEndpints(typeof(Program));
            return Ok(result);
        }
    }
}
