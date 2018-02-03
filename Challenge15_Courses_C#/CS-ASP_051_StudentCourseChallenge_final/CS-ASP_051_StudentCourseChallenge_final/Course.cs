using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_051_StudentCourseChallenge_final
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}