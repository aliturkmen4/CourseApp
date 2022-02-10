using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool? Confirm { get; set; } //soru işareti koyarak nullable yaptım!
    }
}
