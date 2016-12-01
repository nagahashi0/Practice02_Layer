using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice02_Layer.Startup))]
namespace Practice02_Layer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
