using Microsoft.AspNetCore.SignalR;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Hubs
{
    public class ChatHub : Hub
    {
        private readonly PortalDbContext _db;

        public ChatHub(PortalDbContext db)
        {
            _db = db;
        }

        public void SendMessage(string fromUserId, string toUserId, string message)
        {
            _db.Messages.Add(new Domain.Models.Message
            {
                Body = message
            });

            _db.SaveChanges();

            Clients.User(toUserId)
                .SendAsync("updateMessages", fromUserId, toUserId, message);
        }


        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("updateUserStatus", Context.User.Identity.Name, true);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("updateUserStatus", Context.User.Identity.Name, false);
        }

        public void SendTypingStatus(string fromUserId, string toUserId, string typingStatus)
        {           
            Clients.User(toUserId)
                .SendAsync("updateTypingStatus", fromUserId,toUserId, typingStatus);
        }


    }
}
