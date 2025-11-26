using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class GenericControlsController : ControllerBase
    {
		[HttpGet("GetLocalizedResources")]
		public async Task<IActionResult> GetLocalizedResources()
		{
			return Ok(new { Success = true });
		}
	}
}
