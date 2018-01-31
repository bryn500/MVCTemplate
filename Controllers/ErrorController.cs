using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
    public class ErrorController : BaseController
    {
        [HttpGet]
        [Route("404")]
        public ActionResult Http404()
        {
            ViewBag.Title = "404 Error";

            Response.StatusCode = 404;
            Response.Status = "404 Not Found";

            return View();
        }

        [HttpGet]
        [Route("500")]
        public ActionResult Http500()
        {
            ViewBag.Title = "500 Error";

            Response.StatusCode = 500;
            Response.Status = "500 Internal Server Error";

            return View();
        }
    }
}