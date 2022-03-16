using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Chat_API_SignalR.Hubs.Model
{
    public class MessageInstance
    {
        public string TimeStamp { get; set; }
        public string From { get; set; }
        public string Message { get; set; }

    }
}
