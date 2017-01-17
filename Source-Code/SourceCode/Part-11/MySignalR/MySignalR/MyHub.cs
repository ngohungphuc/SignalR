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
        public override System.Threading.Tasks.Task OnConnected()
        {
            return Clients.All.log("Connected  "+DateTime.Now.ToString());
        }
        public override  System.Threading.Tasks.Task OnDisconnected()
        {
            return Clients.All.log("DisConnected  " + DateTime.Now.ToString());
        }

        public void servermethod(string name, string msg)
        {            
            Clients.All.clientmethod(name,Context.ConnectionId, msg);
        }
    }
}