using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BaseController : ControllerBase
    {

        [HttpGet("CheckBrowser")]
        public async Task<IActionResult> CheckBrowser()
        {
            return Ok(new { Success = true});

		}
    }
}
