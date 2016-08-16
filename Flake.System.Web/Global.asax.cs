using System;
using System.Web.Routing;

namespace Flake.System.Web
{
    public class Global : global::System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.LowercaseUrls = true;
        }
    }
}