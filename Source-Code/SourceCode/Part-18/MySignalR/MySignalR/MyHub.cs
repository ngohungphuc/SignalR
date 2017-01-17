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

        public void servermethod(string msg)
        {
            string ConId = Context.ConnectionId.ToString();
            Clients.Group(Clients.Caller.g).clientmethod(Clients.Caller.n, ConId, msg);   
        }
    }

    public class Notify
    {
        public static void Say(string msg)
        {
            var AllContext = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            AllContext.Clients.All.sayClient(msg);
        }
    }
}