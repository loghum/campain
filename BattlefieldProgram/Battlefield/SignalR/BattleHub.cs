using Microsoft.AspNetCore.SignalR;

namespace SignalR;

public class BattleHub : Hub
{
    public async Task MoveToken(string battlefieldId,string tokenId, int x, int y)
    {
        // Broadcast to all clients except the sender
        await Clients.Group(battlefieldId).SendAsync("TokenMoved", tokenId, x, y);
    }
    
    public async Task CreateToken(string battlefieldId,string id, int x, int y, string color, bool dmOnly, string? imageUrl)
    {
        await Clients.Group(battlefieldId).SendAsync("TokenCreated", id, x, y, color, dmOnly, imageUrl);
    }
    
    public async Task JoinBattlefield(string battlefieldId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, battlefieldId);
    }
    
    public async Task LeaveBattlefield(string battlefieldId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, battlefieldId);
    }
    
    public async Task SetActiveBattlefield(string battlefieldId)
    {
        await Clients.All.SendAsync("ActiveBattlefieldChanged", battlefieldId);
    }
}