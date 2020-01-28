using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pc805215_MIS4200.Startup))]
namespace pc805215_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
