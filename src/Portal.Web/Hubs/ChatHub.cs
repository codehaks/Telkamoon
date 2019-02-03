using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string userId,string fromUser,string message)
        {
            Clients.User(userId).SendAsync("updateMessages",fromUser, message);
        }

       

    }
}
