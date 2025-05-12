using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cocteleria_kris_backend.Controllers;

[Authorize] // Apply this attribute to the entire controller
[ApiController]
[Route("api/[controller]")]
public class ProtectedController : ControllerBase
{
    [HttpGet("data")]
    public IActionResult GetData()
    {
        return Ok(new { Message = "This is protected data!", User = User.Identity?.Name });
    }
}
