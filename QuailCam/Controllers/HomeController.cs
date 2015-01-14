using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuailCam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TODO: fill in this page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "TODO: fill in this page";

            return View();
        }
    }
}