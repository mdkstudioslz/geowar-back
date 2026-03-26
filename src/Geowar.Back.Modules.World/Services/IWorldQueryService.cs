using Geowar.Back.Modules.World.Contracts;

namespace Geowar.Back.Modules.World.Services;

public interface IWorldQueryService
{
    IReadOnlyList<WorldRegionOverviewResponse> GetRegions();
    WorldRegionOverviewResponse? GetRegion(string regionId);
}
