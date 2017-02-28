using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumatorForNumbersWeb.Startup))]
namespace SumatorForNumbersWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
