using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace $safeprojectname$
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //// Used to help clear output cache
            //HttpRuntime.Cache.Insert("Pages", DateTime.Now);

            //// Remove X-AspNetMvc-Version HTTP header 
            //MvcHandler.DisableMvcResponseHeader = true;
        }
    }
}
