using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SecurityController : ControllerBase
    {
		[HttpGet("GetIsAdministrator")]
		public async Task<IActionResult> GetIsAdministrator()
		{
			return Ok(new { Success = true });
		}

		[HttpGet("GetCanLinkUsersFromOtherOrganizations")]
		public async Task<IActionResult> GetCanLinkUsersFromOtherOrganizations()
		{
			return Ok(new { Success = true });
		}

		[HttpGet("GetCanViewAllOrganizations")]
		public async Task<IActionResult> GetCanViewAllOrganizations()
		{
			return Ok(new { Success = true });
		}
	}
}
