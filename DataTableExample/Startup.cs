using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataTableExample.Startup))]
namespace DataTableExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
