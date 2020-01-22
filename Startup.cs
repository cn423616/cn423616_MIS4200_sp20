using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cn423616_MIS4200.Startup))]
namespace cn423616_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
