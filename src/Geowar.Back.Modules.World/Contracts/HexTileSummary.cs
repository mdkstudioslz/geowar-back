using Geowar.Back.BuildingBlocks.Domain;

namespace Geowar.Back.Modules.World.Contracts;

public sealed record HexTileSummary(
    HexCoordinates Coordinates,
    TerrainType Terrain,
    int ExpansionCost,
    int VisibilityDifficulty,
    ResourceStock ResourceYield,
    bool HasStrategicRoute);
