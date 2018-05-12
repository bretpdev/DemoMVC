using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        //  site/home/index
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

        //  site/home/abouts
        public ActionResult About()
		{
			ViewBag.Message = "This is the about page";

			return View();
		}

		[HttpPost]
        public ActionResult About(string userData)
		{
			ViewBag.Message = userData;
			return View();
		}

        //  site/home/list
        public ActionResult List()
		{
			return View(TechItem.GetItems());
		}
    }
}
