using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200393517__class_project.Startup))]
namespace _200393517__class_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
