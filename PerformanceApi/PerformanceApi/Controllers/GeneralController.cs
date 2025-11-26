using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class GeneralController : ControllerBase
    {
		[HttpGet("GetGeneralApplicationData")]
		public async Task<IActionResult> GetGeneralApplicationData()
		{
			return Ok(new { Success = true });
		}
	}
}
