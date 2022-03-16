using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Simple_Chat_API_Identity_Test.Hubs.Implement;
using Simple_Chat_API_Identity_Test.Hubs.Interface;
using Simple_Chat_API_Identity_Test.Hubs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Chat_API_Identity_Test.Controllers
{
    [Route("signalr1")]
    public class ChatController: Controller 
    {
        private IHubContext<SignalRHub, IHubClient> _signalRHub;

        public ChatController(IHubContext<SignalRHub, IHubClient> signalRHub)
        {
            _signalRHub = signalRHub;
        }

        public async Task<string> Post([FromBody] MessageInstance msg)
        {
            var retMess = string.Empty;
            try
            {
                msg.TimeStamp = DateTime.UtcNow.ToString();
                await _signalRHub.Clients.All.BroadcastMessage(msg);
                retMess = "Success";
            }
            catch (Exception e)
            {

                retMess = e.ToString();
            }
            return retMess;
        }
    }
}
