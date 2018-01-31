using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace $safeprojectname$.Controllers
{
    public class BaseController : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            // Used to help clear output cache sitewide
            requestContext.HttpContext.Response.AddCacheItemDependency("Pages");

            base.Initialize(requestContext);
        }
    }
}