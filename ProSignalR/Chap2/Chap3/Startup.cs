using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chap3.Startup))]
namespace Chap3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapHubs("/chapter3signalr", new Microsoft.AspNet.SignalR.HubConfiguration());
            //HubConfiguration configuration = new HubConfiguration();
            //configuration.EnableCrossDomain = true;
            //app.MapHubs(configuration);
            app.MapHubs();
            //ConfigureAuth(app);
        }
    }
}
