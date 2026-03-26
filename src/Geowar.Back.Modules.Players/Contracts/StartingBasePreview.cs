using Geowar.Back.BuildingBlocks.Domain;

namespace Geowar.Back.Modules.Players.Contracts;

public sealed record StartingBasePreview(
    string RegionId,
    string RegionName,
    HexCoordinates Coordinates,
    TerrainType Terrain,
    ResourceStock StartingResources,
    string StrategicFocus);
