using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR
{
    [HubName("myhub")]
    public class MyHub : Hub
    {
        public string serverMethod(string msg)
        {
            return msg;
        }
    }
}