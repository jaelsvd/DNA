using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNA.Startup))]
namespace DNA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
