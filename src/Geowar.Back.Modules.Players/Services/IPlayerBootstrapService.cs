using Geowar.Back.Modules.Players.Contracts;

namespace Geowar.Back.Modules.Players.Services;

public interface IPlayerBootstrapService
{
    PlayerBootstrapResponse CreateInitialSetup();
}
