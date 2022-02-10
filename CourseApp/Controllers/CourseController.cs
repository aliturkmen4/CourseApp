using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet] //bana bir kaynak getirdiği için!
        public IActionResult Apply()
        {
            //localhost:44380/course/apply
            return View();
        }
        [HttpPost]
        public IActionResult Apply(string Name, string Email, string Phone, bool Confirm) //görevi servera post etmek !
        {
            //localhost:44380/course/apply methodu:POST 
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
