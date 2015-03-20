using mvcRef.Models;
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

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult TodosPage()
        {
            ViewBag.TodoGreeting = "Here are the chores...";
            TodoIndexVM viewModel = new TodoIndexVM();
            viewModel.Greeting = "Howdy Pard'ner!";

            List<Todo> tList = new List<Todo>(){
                new Todo(){Id=0, Task="Clean Garage", isCompleted=false, dateCreated=DateTime.Now.AddDays(-7)},
                new Todo(){Id=1, Task="Wash Dishes", isCompleted=true, dateCreated=DateTime.Now.AddDays(-6)},
                new Todo(){Id=2, Task="Vacuum", isCompleted=false, dateCreated=DateTime.Now.AddDays(-5)}
            };

            viewModel.myChores = tList;
            return View(viewModel);
        }
    }
}