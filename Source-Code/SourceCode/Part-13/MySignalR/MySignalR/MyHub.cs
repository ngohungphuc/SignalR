using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MySignalR
{
    [HubName("myhub")]
    public class MyHub:Hub
    {
        public void servermethod(string name, string msg)
        {
            string ConId = Context.ConnectionId.ToString();
            //Clients.All.clientmethod(name, ConId, msg); 
            //Clients.Caller.clientmethod(name, ConId, msg);
            Clients.Others.clientmethod(name,ConId, msg);
        }
    }
}