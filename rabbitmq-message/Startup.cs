using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rabbitmq_message.Startup))]
namespace rabbitmq_message
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
