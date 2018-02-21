
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace EF_CodeFirst.Models
    // Models class is what is "code-first"; it is laying out the dB with code
    //     it is what is converted into the table
{
    public class Student
    {
        public int ID { get; set; } // EF auto-assigns this as key
        public string StudentName { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
    }
}