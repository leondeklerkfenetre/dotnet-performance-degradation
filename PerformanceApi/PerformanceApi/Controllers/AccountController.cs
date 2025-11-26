using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AccountController : ControllerBase
    {
		[HttpGet("GetGUISettings")]
		public async Task<IActionResult> GetGUISettings()
		{
			return Ok(new { Success = true });
		}
		 

		[HttpGet("IsCIDRValid")]
		public async Task<IActionResult> IsCIDRValid()
		{
			return Ok(new { Success = true });
		}

		[HttpGet("GetOrganizationGUISettings")]
		public async Task<IActionResult> GetOrganizationGUISettings([FromQuery] bool overrideWithUserPreference)
		{
			return Ok(new { Success = true });
		}
	}
}
