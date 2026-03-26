using Geowar.Back.BuildingBlocks.Domain;
using Geowar.Back.Modules.World.Contracts;

namespace Geowar.Back.Modules.World.Services;

internal sealed class InMemoryWorldQueryService : IWorldQueryService
{
    private static readonly IReadOnlyList<WorldRegionOverviewResponse> Regions =
    [
        new WorldRegionOverviewResponse(
            "sa-east-coast",
            "Costa Sudeste",
            "Tropical umido",
            "south-america-br-1",
            [
                "Rotas maritimas favorecem comercio",
                "Alta pressao por territorio urbano",
                "Boa base para diplomacia e logistica"
            ],
            [
                new HexTileSummary(
                    new HexCoordinates(-12, 44),
                    TerrainType.Coastal,
                    ExpansionCost: 30,
                    VisibilityDifficulty: 1,
                    new ResourceStock(Wood: 25, Ore: 10, Oil: 4, Water: 20, Credits: 12),
                    HasStrategicRoute: true),
                new HexTileSummary(
                    new HexCoordinates(-11, 45),
                    TerrainType.Urban,
                    ExpansionCost: 55,
                    VisibilityDifficulty: 1,
                    new ResourceStock(Wood: 8, Ore: 6, Oil: 2, Water: 10, Credits: 30),
                    HasStrategicRoute: true)
            ]),
        new WorldRegionOverviewResponse(
            "sa-forest-belt",
            "Cinturao Florestal",
            "Equatorial",
            "south-america-br-1",
            [
                "Alta oferta de madeira e agua",
                "Movimentacao militar mais lenta",
                "Boa regiao para economia de base"
            ],
            [
                new HexTileSummary(
                    new HexCoordinates(-18, 37),
                    TerrainType.Forest,
                    ExpansionCost: 35,
                    VisibilityDifficulty: 3,
                    new ResourceStock(Wood: 40, Ore: 6, Oil: 1, Water: 22, Credits: 8),
                    HasStrategicRoute: false),
                new HexTileSummary(
                    new HexCoordinates(-19, 36),
                    TerrainType.Forest,
                    ExpansionCost: 38,
                    VisibilityDifficulty: 4,
                    new ResourceStock(Wood: 44, Ore: 5, Oil: 0, Water: 24, Credits: 7),
                    HasStrategicRoute: false)
            ]),
        new WorldRegionOverviewResponse(
            "sa-mountain-line",
            "Cordilheira Interior",
            "Temperado de altitude",
            "south-america-br-2",
            [
                "Excelente extracao mineral",
                "Defesa facilitada por terreno elevado",
                "Expansao mais cara e lenta"
            ],
            [
                new HexTileSummary(
                    new HexCoordinates(-9, 29),
                    TerrainType.Mountain,
                    ExpansionCost: 60,
                    VisibilityDifficulty: 2,
                    new ResourceStock(Wood: 10, Ore: 38, Oil: 6, Water: 9, Credits: 14),
                    HasStrategicRoute: false),
                new HexTileSummary(
                    new HexCoordinates(-10, 28),
                    TerrainType.Desert,
                    ExpansionCost: 48,
                    VisibilityDifficulty: 2,
                    new ResourceStock(Wood: 3, Ore: 14, Oil: 18, Water: 4, Credits: 10),
                    HasStrategicRoute: false)
            ])
    ];

    public IReadOnlyList<WorldRegionOverviewResponse> GetRegions() => Regions;

    public WorldRegionOverviewResponse? GetRegion(string regionId)
    {
        return Regions.FirstOrDefault(region =>
            string.Equals(region.RegionId, regionId, StringComparison.OrdinalIgnoreCase));
    }
}
