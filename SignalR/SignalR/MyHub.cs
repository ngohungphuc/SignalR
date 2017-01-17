using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR
{
    internal class Info
    {
        public string ConId { get; set; }
        public string ConStatus { get; set; }
        public string Transport { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
    }

    //step 1 create a hub
    [HubName("myhub")]
    public class MyHub : Hub
    {
        private static List<string> ConnectionIds;

        static MyHub()
        {
            ConnectionIds = new List<string>();
        }

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
        //public void servermethod(string name, string msg)
        //{
        //    string connectionId = Context.ConnectionId;
        //    Clients.Others.clientMethod(name, connectionId, msg);
        //    //Clients.Caller.clientMethod(name, connectionId, msg);
        //    //Clients.All.clientMethod(name, connectionId, msg);
        //}

        //public override Task OnConnected()
        //{
        //    Info info = new Info();
        //    info.ConId = Context.ConnectionId;
        //    info.ConStatus = Context.Headers["Connection"];
        //    info.Transport = Context.QueryString["transport"];
        //    info.Host = Context.Request.Url.Host;
        //    info.Port = Context.Request.Url.Port.ToString();
        //    info.Username = Context.User.Identity.Name;
        //    return Clients.All.log(info);
        //}

        //public override Task OnDisconnected(bool stopCalled)
        //{
        //    return Clients.All.log("DisConnected " + DateTime.Now);
        //}

        //public override Task OnConnected()
        //{
        //    ConnectionIds.Add(Context.ConnectionId);
        //    return base.OnConnected();
        //}

        //public void servermethod(string name, string msg)
        //{
        //    string ConId = Context.ConnectionId;
        //    //send message to second connection
        //    Clients.Client(ConnectionIds[1]).clientmethod(name, ConId, msg);
        //    //we have allexcept method
        //}

        public void join(string group)
        {
            Groups.Add(Context.ConnectionId, group);
            //Groups.Remove();
        }

        public void servermethod(string name, string msg)
        {
            string ConId = Context.ConnectionId;
            Clients.All.clientmethod(name, ConId, msg);
        }
    }
}