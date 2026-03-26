using Geowar.Back.Modules.World.Services;
using Microsoft.AspNetCore.Mvc;

namespace Geowar.Back.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class WorldController(IWorldQueryService worldQueryService) : ControllerBase
{
    [HttpGet("regions")]
    public IActionResult GetRegions()
    {
        return Ok(worldQueryService.GetRegions());
    }

    [HttpGet("regions/{regionId}")]
    public IActionResult GetRegion(string regionId)
    {
        var region = worldQueryService.GetRegion(regionId);
        return region is null ? NotFound() : Ok(region);
    }
}
