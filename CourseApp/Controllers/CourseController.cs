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
        public string Index()
        {
            //localhost:44380/home/index
            return "Course/Index";
        }
        public string List()
        {
            //localhost:44380/home/list
            return "Course/List";
        }
    }
}
