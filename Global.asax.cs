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

            // Used to help clear output cache
            HttpRuntime.Cache.Insert("Pages", DateTime.Now);

            // Remove X-AspNetMvc-Version HTTP header 
            MvcHandler.DisableMvcResponseHeader = true;
        }

        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            // Remove Server HTTP Header
            HttpContext.Current.Response.Headers.Remove("Server");
        }

        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (String.IsNullOrEmpty(custom))
                return base.GetVaryByCustomString(context, custom);

            // do not output cache: return Guid.NewGuid().ToString();

            // vary cache based on custom requirements
            List<string> retVal = new List<string>();
            List<string> customParts = custom.Split(new char[] { ',', ';' }).ToList();

            foreach (var customPart in customParts)
            {
                // if we are meant to vary by part
                // add vary string to retval
            }

            return string.Join(";", retVal);
        }
    }
}
