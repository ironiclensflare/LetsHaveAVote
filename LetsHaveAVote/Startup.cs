using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LetsHaveAVote.Startup))]
namespace LetsHaveAVote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
