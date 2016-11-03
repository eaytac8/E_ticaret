using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ayakkabi_Projesi.Startup))]
namespace Ayakkabi_Projesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
