using Geowar.Back.Api.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Geowar.Back.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class SystemController : ControllerBase
{
    [HttpGet("overview")]
    public IActionResult GetOverview()
    {
        var response = new SystemOverviewResponse(
            "GeoWar Backend",
            "Monolito modular orientado a eventos",
            ActiveModules:
            [
                "API Gateway inicial",
                "Players",
                "World",
                "Realtime"
            ],
            PlannedIntegrations:
            [
                "PostgreSQL para persistencia",
                "Redis para estado de mapa e sessoes",
                "SignalR para sincronizacao de proximidade",
                "Mensageria para construcoes, combate e economia"
            ],
            RealTimeChannels:
            [
                "/hubs/world"
            ]);

        return Ok(response);
    }
}
