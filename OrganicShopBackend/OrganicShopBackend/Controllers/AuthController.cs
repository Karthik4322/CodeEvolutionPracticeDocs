using Microsoft.AspNetCore.Mvc;
using OrganicShopBackend.Services;
using System.Threading.Tasks;

namespace OrganicShopBackend.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            var token = await _authService.AuthenticateUser(model.Email, model.Password);
            if (token == null) return Unauthorized();

            return Ok(new { Token = token });
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Signup([FromBody] SignupRequest model)
        {
            var result = await _authService.RegisterUser(model);
            if (!result)
                return BadRequest("User registration failed");

            return Ok(new { Message = "User registered successfully" });
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
