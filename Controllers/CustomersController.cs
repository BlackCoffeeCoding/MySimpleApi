using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var customers = new[] {
new Customer { Id = 1, FullName = "Kirill" },
new Customer { Id = 2, FullName = "Solntsev" },
new Customer { Id = 3, FullName = "Customer 1" },
new Customer { Id = 4, FullName = "Customer 2" },
new Customer { Id = 5, FullName = "Customer 3" }
};
            return Ok(customers);
        }
    }
}