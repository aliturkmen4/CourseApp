using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController : Controller 
    {        
        public IActionResult Index()
        {
            int time = DateTime.Now.Hour;
            ViewBag.Greeting = time > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Ali";

            //localhost:44380/home/index => home/index.cshtml
            return View();
        }
        public IActionResult About()
        {
            //localhost:44380/home/about =>home/about.cshtml
            return View();
        }
    }
}
