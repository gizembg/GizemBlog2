using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GizemBlog2.Startup))]
namespace GizemBlog2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
