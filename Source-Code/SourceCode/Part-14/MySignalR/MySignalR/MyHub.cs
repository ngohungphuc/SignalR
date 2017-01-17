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

        static private List<string> ConnectionIds;

        static MyHub()
        {
            ConnectionIds = new List<string>();
        }

        public override System.Threading.Tasks.Task OnConnected()
        {
            ConnectionIds.Add(Context.ConnectionId);
            return base.OnConnected();
        }

        public void servermethod(string name, string msg)
        {
            string ConId = Context.ConnectionId.ToString();
            Clients.AllExcept(ConnectionIds.Take(2).ToArray()).clientmethod(name, ConId, msg); 
            
        }
    }
}