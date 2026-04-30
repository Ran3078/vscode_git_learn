using Microsoft.AspNetCore.Mvc;

namespace learn_git.Controllers;

[ApiController]
[Route("api")]
public class SystemController : ControllerBase
{
    private readonly IHostEnvironment _hostEnvironment;

    public SystemController(IHostEnvironment hostEnvironment)
    {
        _hostEnvironment = hostEnvironment;
    }

    [HttpGet("version")]
    public IActionResult GetVersion()
    {
        return Ok(new
        {
            version = "1.0.0",
            environment = _hostEnvironment.EnvironmentName
        });
    }

    [HttpGet("time")]
    public IActionResult GetCurrentTime()
    {
        var now = DateTimeOffset.Now;
        return Ok(new
        {
            now = now.ToString("O"),
            unixTimeSeconds = now.ToUnixTimeSeconds()
        });
    }

    [HttpGet("healthy")]
    public IActionResult GetStatus()
    {
        return Ok("healthy");
    }
}
