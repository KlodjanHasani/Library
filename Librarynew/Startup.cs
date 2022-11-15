using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Librarynew.Startup))]
namespace Librarynew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
