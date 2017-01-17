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
        public string servermethod(string msg)
        {
            return msg+" ManzoorTheTrainer!";
        }
    }
}