using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCore.Hubs
{
    public class MyHub : Hub
    {
        public void MyServerFunction()
        {
            Clients.All.clientListener($"Your connection id is: {Context.ConnectionId}");
        }
    }
}
