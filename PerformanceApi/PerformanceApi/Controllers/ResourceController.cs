using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ResourceController : ControllerBase
    {
		[HttpGet("GetLocalizedResources")]
		public async Task<IActionResult> GetLocalizedResources()
		{
			return Ok(new { Success = true });
		}

		[HttpGet("GetGlobalResources")]
		public async Task<IActionResult> GetGlobalResources()
		{
			return Ok(new { Success = true });
		}
		
	}
}
