using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_051_StudentCourseChallenge_final
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        // added this for Button 3 assignment
        public List<ReportCard> Grades { get; set; }
    }
}