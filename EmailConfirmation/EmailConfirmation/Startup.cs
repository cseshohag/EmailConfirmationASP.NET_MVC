using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailConfirmation.Startup))]
namespace EmailConfirmation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
