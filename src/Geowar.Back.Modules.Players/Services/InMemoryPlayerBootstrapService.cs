using Geowar.Back.BuildingBlocks.Domain;
using Geowar.Back.Modules.Players.Contracts;

namespace Geowar.Back.Modules.Players.Services;

internal sealed class InMemoryPlayerBootstrapService : IPlayerBootstrapService
{
    public PlayerBootstrapResponse CreateInitialSetup()
    {
        return new PlayerBootstrapResponse(
            Guid.NewGuid(),
            "Operador Atlas",
            VisionRange: 2,
            RecommendedShard: "south-america-br-1",
            StartingBases:
            [
                new StartingBasePreview(
                    "sa-east-coast",
                    "Costa Sudeste",
                    new HexCoordinates(-12, 44),
                    TerrainType.Coastal,
                    new ResourceStock(Wood: 120, Ore: 40, Oil: 15, Water: 110, Credits: 300),
                    "Comercio e logistica"),
                new StartingBasePreview(
                    "sa-forest-belt",
                    "Cinturao Florestal",
                    new HexCoordinates(-18, 37),
                    TerrainType.Forest,
                    new ResourceStock(Wood: 180, Ore: 25, Oil: 10, Water: 90, Credits: 260),
                    "Extracao e expansao inicial"),
                new StartingBasePreview(
                    "sa-mountain-line",
                    "Cordilheira Interior",
                    new HexCoordinates(-9, 29),
                    TerrainType.Mountain,
                    new ResourceStock(Wood: 70, Ore: 160, Oil: 20, Water: 60, Credits: 280),
                    "Mineracao e defesa")
            ],
            InitialPriorities:
            [
                "Escolher uma base inicial conectada a recursos sustentaveis",
                "Construir economia antes de acelerar expansao militar",
                "Priorizar visibilidade e controle de hexagonos adjacentes"
            ]);
    }
}
