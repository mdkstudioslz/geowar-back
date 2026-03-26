using Geowar.Back.Modules.World.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Geowar.Back.Modules.World;

public static class DependencyInjection
{
    public static IServiceCollection AddWorldModule(this IServiceCollection services)
    {
        services.AddSingleton<IWorldQueryService, InMemoryWorldQueryService>();
        return services;
    }
}
