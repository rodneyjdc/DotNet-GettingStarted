using Microsoft.AspNetCore.Mvc;

namespace dotNetStarter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("headerInfo/")]
        public IActionResult GetHeaders() {
            // return Ok("Hello from .NET Core!");
            base.Response.Cookies.Append("message", "This message is a cookie!");
            var headers = base.Request.Headers;
            return base.Ok(headers);
        }

        [HttpGet]
        [Route("queryInfo/")]
        public IActionResult GetQueries() {
            var queries = base.Request.QueryString;
            return base.Ok(queries);
        }
    }
}