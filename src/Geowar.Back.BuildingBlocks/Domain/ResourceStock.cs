namespace Geowar.Back.BuildingBlocks.Domain;

public sealed record ResourceStock(
    int Wood,
    int Ore,
    int Oil,
    int Water,
    int Credits);
