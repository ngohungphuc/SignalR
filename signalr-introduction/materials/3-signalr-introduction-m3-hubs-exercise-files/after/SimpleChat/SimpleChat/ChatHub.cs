using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Threading.Tasks;

namespace SimpleChat
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            var msg = String.Format(
                "{0}: {1}", Context.ConnectionId, message);
            Clients.All.newMessage(msg);
        }

        public void JoinRoom(string room)
        {
            // NOTE: this is not persisted - ....
            Groups.Add(Context.ConnectionId, room);
        }

        public void SendMessageToRoom(string room, string message)
        {
            var msg = String.Format(
                "{0}: {1}", Context.ConnectionId, message);
            Clients.Group(room).newMessage(msg);
        }

        public void SendMessageData(SendData data)
        {
            // process incoming data...
            // transform data...
            // craft new data...

            Clients.All.newData(data);
        }

        //public Task<int> SendDataAsync()
        //{
        //    // async ... work...
        //}

        public override Task OnConnected()
        {
            SendMonitoringData("Connected", Context.ConnectionId);
            return base.OnConnected();
        }

        public override Task OnDisconnected()
        {
            SendMonitoringData("Disconnected", Context.ConnectionId);
            return base.OnDisconnected();
        }

        public override Task OnReconnected()
        {
            SendMonitoringData("Reconnected", Context.ConnectionId);
            return base.OnReconnected();
        }

        private void SendMonitoringData(string eventType, string connection)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<MonitorHub>();
            context.Clients.All.newEvent(eventType, connection);
        }
    }

    public class SendData
    {
        public int Id { get; set; }
        public string Data { get; set; }
    }
}