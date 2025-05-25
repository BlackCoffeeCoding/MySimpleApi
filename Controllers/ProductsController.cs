using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new[] {
new Product { Id = 1, Name = "Pasta" },
new Product { Id = 2, Name = "Cake" },
new Product { Id = 3, Name = "Lime" },
new Product { Id = 4, Name = "Cinnabon" },
new Product { Id = 5, Name = "Oil" }
};
            return Ok(products);
        }
    }
}