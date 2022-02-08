using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController : Controller 
    {        
        public string Index()
        {
            //localhost:44380/home/index
            return "Home/Index";
        }
        public string About()
        {
            //localhost:44380/home/about
            return "Home/About";
        }
    }
}
