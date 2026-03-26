using Microsoft.AspNetCore.SignalR;

namespace Geowar.Back.Api.Hubs;

public sealed class WorldHub : Hub
{
    public Task SubscribeToShard(string shardId)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, shardId);
    }
}
