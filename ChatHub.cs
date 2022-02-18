using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string fromUser, string toUser, string theme, string text, DateTime date)
        {
            await Clients.All.SendAsync("ReceiveMessage", fromUser, toUser, theme, text, date);
        }
    }
}
