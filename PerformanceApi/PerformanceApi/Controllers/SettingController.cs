using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SettingController : ControllerBase
    {

		[HttpGet("GetGenericFrontendSettings")]
		public async Task<IActionResult> GetGenericFrontendSettings()
		{
			return Ok(new { Success = true });
		}

		[HttpGet("GetGlobalTabsSetting")]
		public async Task<IActionResult> GetGlobalTabsSetting()
		{
			return Ok(new { Success = true });
		}
	}
}
