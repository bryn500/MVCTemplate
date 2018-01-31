using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
    public class HomeController : BaseController
    {
        [HttpGet]
        [Route("")]
        //[OutputCache(Duration = 86400, Location = System.Web.UI.OutputCacheLocation.Server, VaryByParam = "none")]
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}