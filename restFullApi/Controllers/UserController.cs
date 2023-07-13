using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace restFullApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet] 
        public IActionResult GetData()
        {
            return Ok("Test");
        }
    }
}
