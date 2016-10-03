using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void SaySomething(string message)
        {
            Clients.All.speak(message + " from the server");
        }
    }
}