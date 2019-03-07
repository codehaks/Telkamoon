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

        public void SendMessage(string userId, string fromUser, string message)
        {
            _db.Messages.Add(new Domain.Models.Message
            {
                Body = message
            });

            Clients.User(userId)
                .SendAsync("updateMessages", fromUser, message);
        }
    }
}
