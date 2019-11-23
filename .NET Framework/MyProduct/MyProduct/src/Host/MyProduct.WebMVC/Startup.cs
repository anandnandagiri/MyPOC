using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Product.WebMVC.Startup))]
namespace Product.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
