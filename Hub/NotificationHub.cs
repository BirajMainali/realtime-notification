using Microsoft.AspNetCore.SignalR;

namespace notifier.Hub;

public class NotificationHub: Microsoft.AspNetCore.SignalR.Hub
{
    public async Task OnUserPresent(string message) 
        => await Clients.All.SendAsync("onUserPresent", message);
}