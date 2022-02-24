using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseApp.Controllers
{
    public class CourseController : Controller //controller sınıfı 1.satırdaki namesapace içinde olduğundan buraya tanıtmak için 1.satırı ekliyoruz!
    {
        //yetenek kazandıracak methodlar(action method)
        public IActionResult Index()
        {
            var kurs = new Course() { Id = 1, Name = "Komple Uygulamalı Web Geliştirme" };
            ViewData["course"] = kurs;
            ViewBag.course = kurs;
            //localhost:44380/course/index => course/index.cshtml
            return View();
        }
        [HttpGet] //bana bir kaynak getirdiği için!
        public IActionResult Apply()
        {
            //localhost:44380/course/apply
            return View();
        }
        [HttpPost]
        public IActionResult Apply(Student student) //görevi servera post etmek !
        {
            
            if (ModelState.IsValid) //required alanlar sağlanıyor mu ?
            {
                Repository.AddStudent(student);
                //localhost:44380/course/apply methodu:POST 
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }
          
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
            var students = Repository.Students.Where(i => i.Confirm == true);
            //localhost:44380/home/list => course/list.cshtml
            return View(students);
        }
        public ActionResult CourseList(int? pageindex,string sortby)
        {
            if (!pageindex.HasValue)
            {
                pageindex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortby))
            {
                sortby = "name";
            }
            return Content("pageindex= " + pageindex + "sortby= " + sortby);
        }

        public ActionResult ByReleased(int year,int month)
        {
            return Content("year: " + year + "month: " + month);
        }

    }
}
