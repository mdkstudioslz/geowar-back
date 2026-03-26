namespace Geowar.Back.Modules.World.Contracts;

public sealed record WorldRegionOverviewResponse(
    string RegionId,
    string DisplayName,
    string ClimateProfile,
    string ShardId,
    IReadOnlyList<string> StrategicTraits,
    IReadOnlyList<HexTileSummary> HighlightedHexes);
