using Blog.Attributes;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        //[HttpGet("")]
        //public IActionResult Get()
        //{
        //    return Ok("Api version 0.01");
        //}
        [HttpGet("")]
        public IActionResult Get(
            [FromServices] IConfiguration config)
        {
            var env = config.GetValue<string>("Env");
            return Ok($"Api version 0.01 Enviroment: {env}");
        }

    }
}
