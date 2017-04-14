using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerInvoiceSystem.Startup))]
namespace CustomerInvoiceSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
