using Microsoft.AspNetCore.SignalR;
using Simple_Chat_API_SignalR.Hubs.Interface;
using Simple_Chat_API_SignalR.Hubs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Chat_API_SignalR.Hubs.Implement
{
    public class SignalRHub : Hub<IHubClient>
    {
        public async Task BroadcastMessage(MessageInstance msg)
        {
            await Clients.All.BroadcastMessage(msg);
        }
    }
}
