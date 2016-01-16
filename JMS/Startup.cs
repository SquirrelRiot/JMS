using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMS.Startup))]
namespace JMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //test
        }
    }
}
