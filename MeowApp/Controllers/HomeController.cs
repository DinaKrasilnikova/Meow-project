using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeowApp.Models;

namespace MeowApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult WordCount()
        {
            return PartialView();
        }

        public ActionResult MeowCount(string inputString)
        {
            int result = MeowModel.MeowCount(inputString);
            return PartialView((object)result.ToString());
        }
    }
}