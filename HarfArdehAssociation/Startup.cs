using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HarfArdehAssociation.Startup))]
namespace HarfArdehAssociation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
