using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop_eCommerce.WebUI.Startup))]
namespace MyShop_eCommerce.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
