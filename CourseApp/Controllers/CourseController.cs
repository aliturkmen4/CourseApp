using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class CourseController : Controller //controller sınıfı 1.satırdaki namesapace içinde olduğundan buraya tanıtmak için 1.satırı ekliyoruz!
    {
        //yetenek kazandıracak methodlar(action method)
        public IActionResult Index()
        {
            //localhost:44380/home/index => course/index.cshtml
            return View(); 
        }

        public IActionResult Details() 
        {
            return View("MyView"); //böyle dersem myview.cshtml oluşturmamı bekler!!
        }
        public IActionResult List()
        {
            //localhost:44380/home/list => course/list.cshtml
            return View();
        }
    }
}
