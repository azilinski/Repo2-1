using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepoWebsite.Startup))]
namespace RepoWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
