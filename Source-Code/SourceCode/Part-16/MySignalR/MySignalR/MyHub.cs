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
        public void join(string group)
        {
            Groups.Add(Context.ConnectionId, group);
        }

        public void servermethod(string name, string msg,string group)
        {
            string ConId = Context.ConnectionId.ToString();
            Clients.Group(group).clientmethod(name, ConId, msg);   
        }
    }
}