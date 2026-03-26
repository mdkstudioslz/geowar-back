using Geowar.Back.Modules.Players.Services;
using Microsoft.AspNetCore.Mvc;

namespace Geowar.Back.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class PlayersController(IPlayerBootstrapService bootstrapService) : ControllerBase
{
    [HttpGet("bootstrap")]
    public IActionResult GetBootstrap()
    {
        return Ok(bootstrapService.CreateInitialSetup());
    }
}
