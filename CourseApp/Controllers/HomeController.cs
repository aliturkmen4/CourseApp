﻿using Microsoft.AspNetCore.Mvc;
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
