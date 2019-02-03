using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Hubs
{
    public class StatusHub : Hub
    {
        public override async Task OnConnectedAsync()
        {

            await Clients.All.SendAsync("updateStatus", Context.User.Identity.Name, "connected");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("updateStatus", Context.User.Identity.Name, "disconnected");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
