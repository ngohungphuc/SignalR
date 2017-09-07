using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Owin;

namespace ConsoleHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var a = Assembly.LoadFrom("Services.dll");

            app.MapHubs(
                new HubConfiguration
                    {
                         EnableCrossDomain = true
                    });
        }
    }
}
