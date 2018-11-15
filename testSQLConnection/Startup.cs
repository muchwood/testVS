using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testSQLConnection.Startup))]
namespace testSQLConnection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
