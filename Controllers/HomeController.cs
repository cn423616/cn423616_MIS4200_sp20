using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cn423616_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Info about ME.";

            return View();
        }
    }
}