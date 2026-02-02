using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.Email == "admin@agro.com" && request.Password == "123456")
        {
            var token = JwtTokenGenerator.Generate(request.Email);
            return Ok(new { token });
        }

        return Unauthorized();
    }
}
