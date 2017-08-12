using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Chap3.Code
{
    [HubName("FirstHub")]
    public class Chapter3Hub : Hub
    {
        public void BroadcastMessage(Person person)
        {
            //Clients.All.displayText(person.Name, person.Message);
            Clients.Group(person.Group).displayText(person.Name, person.Message);
        }

        public Task Join(string groupName)
        {
            return Groups.Add(Context.ConnectionId, groupName);
        }

        public Task Leave(string groupName)
        {
            return Groups.Remove(Context.ConnectionId, groupName);
        }
    }
}