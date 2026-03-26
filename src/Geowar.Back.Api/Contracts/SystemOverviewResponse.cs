namespace Geowar.Back.Api.Contracts;

public sealed record SystemOverviewResponse(
    string Name,
    string ArchitectureStyle,
    IReadOnlyList<string> ActiveModules,
    IReadOnlyList<string> PlannedIntegrations,
    IReadOnlyList<string> RealTimeChannels);
