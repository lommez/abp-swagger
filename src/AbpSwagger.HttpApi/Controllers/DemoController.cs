using AbpSwagger.Enums;
using Microsoft.AspNetCore.Mvc;

namespace AbpSwagger.Controllers
{
    [Route("/api/demo")]
    [ApiController]
    public class DemoController : AbpSwaggerController
    {
        [HttpGet("get-by-origin/{origin}")]
        public IActionResult GetByOrigin(Origin origin)
        {
            return Ok();
        }
    }
}