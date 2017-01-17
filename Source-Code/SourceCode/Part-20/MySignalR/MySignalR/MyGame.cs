using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MyGameApp
{
    [HubName("myGameHub")]
    public class MyGame:Hub
    {
        
           public void send(string name)
            {                  
                    Random r = new Random();
                    string  Top = r.Next(10,300).ToString();
                    string Left = r.Next(10,100).ToString();                    
                    Clients.All.addMessage(Top, Left,name);                
            }
    }
}