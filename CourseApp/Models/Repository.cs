using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public static class Repository //veri tabanı rolünü üstleniyor şu an nesne oluşturmaya ihtiyacım olmadığı için static yaptım!
    {
        private static List<Student> _students = new List<Student>();

        public static List<Student> Students
        {
            get
            {
                return _students;
            }
        }

        //Repository.AddStudent(student);
        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}
