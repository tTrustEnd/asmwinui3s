using Microsoft.AspNetCore.SignalR;

using System.Diagnostics;

namespace SignalR.Hubs;

public class ChatHub : Hub
{
    public ChatHub()
    {
    }
    public async Task GetOnlineGroupMembers(int groupId)
    {
        try
        {
          Debug.WriteLine("public async Task GetOnlineGroupMembers(int groupId)");
          await Clients.All.SendAsync("ReceiveMessage", "HAHA");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
}