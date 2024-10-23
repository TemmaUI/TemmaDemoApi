using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TemmaDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You just received 1M naira");
        }
    }
}
