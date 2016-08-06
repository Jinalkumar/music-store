using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoppingcart_lab1.Startup))]
namespace shoppingcart_lab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
