using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EntityController : ControllerBase
    {
		[HttpGet("Data")]
		public async Task<IActionResult> Data()
		{
			return Ok(new { Success = true });
		}
		
	}
}
