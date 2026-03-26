namespace Geowar.Back.Modules.Players.Contracts;

public sealed record PlayerBootstrapResponse(
    Guid PlayerId,
    string Codename,
    int VisionRange,
    string RecommendedShard,
    IReadOnlyList<StartingBasePreview> StartingBases,
    IReadOnlyList<string> InitialPriorities);
