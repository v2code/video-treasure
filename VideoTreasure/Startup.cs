using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoTreasure.Startup))]
namespace VideoTreasure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
