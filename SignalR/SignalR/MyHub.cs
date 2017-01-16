using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR
{
    //step 1 create a hub
    [HubName("myhub")]
    public class MyHub : Hub
    {
        //    public string serverMethod(string msg)
        //    {
        //        return msg;
        //    }

        //    /// <summary>
        //    /// return message to all client
        //    /// </summary>
        //    /// <param name="msg"></param>
        //    public void serverToClient(string msg)
        //    {
        //        Clients.All.clientMethod(msg);
        //    }

        //step 2 create a server method
        public void servermethod(string name, string msg)
        {
            Clients.All.clientMethod(name, msg);
        }
    }
}