using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcRef.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.greeting = "Hello World!";
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

        public ActionResult TodosPage()
        {
            ViewBag.TodoGreeting = "Here are the chores...";
            return View();
        }
    }
}