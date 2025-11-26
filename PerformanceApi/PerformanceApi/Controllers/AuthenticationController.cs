using Microsoft.AspNetCore.Mvc;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AuthenticationController : ControllerBase
    {

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignInWithEmailPassword([FromBody] LoginData data)
        {
            return Ok(new { Success = true, AccessToken = ""});

		}

		[HttpGet("IsAuthenticated")]
		public async Task<IActionResult> IsAuthenticated()
		{
			return Ok(new { Success = true });

		}

        public class LoginData 
        {
            public string EmailAddress { get; set; }
            public string Password { get; set; }
            public string AuthenticationMethod { get; set; }
		}
	}
}
