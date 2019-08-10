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
                .SendAsync("updateMessages", fromUserId,toUserId, message);
        }
    }
}
