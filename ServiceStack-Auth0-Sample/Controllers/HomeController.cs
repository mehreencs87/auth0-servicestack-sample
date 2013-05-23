using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceStack_Auth0_Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("default.htm");
        }
    }
}
