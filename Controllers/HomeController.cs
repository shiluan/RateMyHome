using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRateMyHome.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rate()
        {
            return View();
        }

        public ActionResult Ratings()
        {
            return View();
        }

        public ActionResult Recaptcha()
        {
            return View();
        }
    }
}
