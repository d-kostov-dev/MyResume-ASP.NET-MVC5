using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyResume.Web.Startup))]
namespace MyResume.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
