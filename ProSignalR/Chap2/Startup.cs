using Chap2.PersistentConnections;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chap2.Startup))]
namespace Chap2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<SamplePersistentConnection>("/SamplePC");
            ConfigureAuth(app);
        }
    }
}
