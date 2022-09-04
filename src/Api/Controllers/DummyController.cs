
using AspNetCoreWebApiBase.Api.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApiBase.Controllers
{
    [ApiController]
    [ApiException]
    [Route("[controller]")]
    public class DummyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello World");
        }
    }
}