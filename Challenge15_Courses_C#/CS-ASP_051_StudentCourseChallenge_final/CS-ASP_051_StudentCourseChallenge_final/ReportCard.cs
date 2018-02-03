using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_051_StudentCourseChallenge_final
{
    public class ReportCard
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public int Grade { get; set; }
    }
}