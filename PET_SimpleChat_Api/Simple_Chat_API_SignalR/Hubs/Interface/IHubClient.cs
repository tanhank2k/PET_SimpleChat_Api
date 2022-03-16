using Simple_Chat_API_SignalR.Hubs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Chat_API_SignalR.Hubs.Interface
{
    public interface IHubClient
    {
        Task BroadcastMessage(MessageInstance msg);
    }
}
