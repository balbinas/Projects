using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDesignAssignment1.Startup))]
namespace WebDesignAssignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
