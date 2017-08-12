using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Chap3.Code
{
    public class Chapter3SecondHub : Hub
    {
        public void SendMessage(string text)
        {
            Clients.Others.displayText(text);
        }
    }
}