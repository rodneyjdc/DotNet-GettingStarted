using Microsoft.AspNetCore.Mvc;

namespace dotNetStarter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            return Ok("Hello from .NET Core!");
        }
    }
}