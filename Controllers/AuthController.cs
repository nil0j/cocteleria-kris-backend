using Microsoft.AspNetCore.Mvc;
using cocteleria_kris_backend.Models;
using cocteleria_kris_backend.Services;

namespace cocteleria_kris_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IJwtService _jwtService;

    public AuthController(IUserService userService, IJwtService jwtService)
    {
        _userService = userService;
        _jwtService = jwtService;
    }

    [HttpPost("register")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> Register([FromForm] UserRegistrationRequest request, IFormFile imageFile)
    {
        if (imageFile != null && imageFile.Length > 0)
        {
            var filePath = Path.Combine(Configuration.FileSystemPath, "users", request.Username + ".png");
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
        }

        var result = await _userService.RegisterUser(request.Username, request.Password);

        if (result.Success)
        {
            return Ok(new { Message = "Registration successful" });
        }
        else
        {
            return BadRequest(new { Error = result.ErrorMessage });
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginRequest request)
    {
        var user = await _userService.AuthenticateUser(request.Username, request.Password);

        if (user != null)
        {
            var token = _jwtService.GenerateToken(user);
            return Ok(new { Token = token });
        }
        else
        {
            return Unauthorized(new { Error = "Invalid username or password." });
        }
    }

    public class UserLoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserRegistrationRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
