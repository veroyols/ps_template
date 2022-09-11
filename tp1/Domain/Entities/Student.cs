using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        //composicion para armar la tabla 1 a 1, Student-StudentAddress
        public StudentAddress Address { get; set; }
        //composicion para armar la tabla 1 a muchos, Student-StudentCourses
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}
