using Geowar.Back.Modules.Players.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Geowar.Back.Modules.Players;

public static class DependencyInjection
{
    public static IServiceCollection AddPlayersModule(this IServiceCollection services)
    {
        services.AddSingleton<IPlayerBootstrapService, InMemoryPlayerBootstrapService>();
        return services;
    }
}
