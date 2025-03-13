using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniEcommerceServer.Application.Repositories.ProductRepositories;

namespace MiniEcommerceServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(),  Name = "Product 1", Price = 100, CreatedDate = DateTime.UtcNow.AddHours(4), Stock = 200},
                new() { Id = Guid.NewGuid(),  Name = "Product 2", Price = 200, CreatedDate = DateTime.UtcNow.AddHours(4), Stock = 300},
                new() { Id = Guid.NewGuid(),  Name = "Product 3", Price =300, CreatedDate = DateTime.UtcNow.AddHours(4), Stock = 400},
                new() { Id = Guid.NewGuid(),  Name = "Product 4", Price = 400, CreatedDate = DateTime.UtcNow.AddHours(4), Stock = 500},
                new() { Id = Guid.NewGuid(),  Name = "Product 5", Price = 500, CreatedDate = DateTime.UtcNow.AddHours(4), Stock =600},
            });
            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id));
        }
    }
}

