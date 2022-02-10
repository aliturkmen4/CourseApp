using CourseApp.Models;
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
            //localhost:44380/course/index => course/index.cshtml
            return View(); 
        }

        public IActionResult Apply()
        {
            //localhost:44380/course/apply
            return View();
        }

        public IActionResult Details() 
        {

            var course = new Course();
            course.Name = "Core MVC Kursu";
            course.Description = "Güzel bir kurs";
            course.isPublished = true;

            return View(course);
            //return View("MyView"); //böyle dersem myview.cshtml oluşturmamı bekler!!
        }
        public IActionResult List()
        {
            //localhost:44380/home/list => course/list.cshtml
            return View();
        }
    }
}
