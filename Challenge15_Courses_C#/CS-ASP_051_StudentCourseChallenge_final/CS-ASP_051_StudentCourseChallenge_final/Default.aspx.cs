using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_051_StudentCourseChallenge_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // It works ... but need tweaks ...

            // To Do:
            // Fix ReportCard v Grades v grade v messed up naming conventions
            // Only used Collection Initializer in Button 2:
                // add button four and do a version w/ collection and object initialization
            // Run on Mac for bigger screen - then consolidate lines ... 
                // this is too spread out to be easily readable



        }



        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
            * Create a List of Courses (add three example Courses ...
            * make up the details).  Each Course should have at least two
            * Students enrolled in them.  Use Object and Collection
            * Initializers.  Then, iterate through each Course and print
            * out the Course's details and the Students that are enrolled in
            * each Course.
            */

            // cosmetics ...
            resultLabel.Text = "<br/><br/><hr><br/>";


            // local variable declaration
            var result = "";


            // Collection initialization
            var courses = new List<Course>()
            //List<Course> courses = new List<Course>()
            {
                new Course
                { CourseId = 101, Name="Claw Sharpening",
                    Students = new List<Student>()
                    {
                        new Student() { StudentId = 1010, Name = "Mittens" },
                        new Student() { StudentId = 1011, Name = "Tom" }
                    }
                },

                new Course
                { CourseId = 102, Name="Catnip Tasting",
                    Students = new List<Student>()
                    {
                        new Student() { StudentId = 1012, Name = "Whiskers" },
                        new Student() { StudentId = 1014, Name = "Kitty-Girl" }
                    }
                },

                new Course
                { CourseId = 103, Name="Quality Naps",
                    Students = new List<Student>()
                    {
                        new Student() { StudentId = 1015, Name = "Boots" },
                        new Student() { StudentId = 1016, Name = "Bob" }
                    }
                }
            };


            // purposefully changed the look - but included all required values.
            //foreach (Course course in courses)
            foreach (var course in courses)
            {
                resultLabel.Text += string.Format
                    ("<br/><br/><b>Course: {0}</b> (course ID: {1})", 
                    course.Name, course.CourseId);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += string.Format
                        ("<br/>&nbsp&nbsp Student: {0} (student ID: {1})", 
                        student.Name, student.StudentId);
                }
            }
            // put resultLabel in place of result above ... two less lines of code ...
            //resultLabel.Text = result;
            resultLabel.Text += "<br/><br/>";

        }










        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */


            // cosmetics ...
            resultLabel.Text = "<br/><br/><hr><br/><br/>";


            // Collection initialization
            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1020, new Student()
                {StudentId= 1020, Name= "Morris",
                    Courses = new List<Course>()
                        {new Course() {CourseId= 104, Name= "Advanced Hairball-ology"},
                        {new Course() {CourseId= 105, Name= "Eliminating Canine Threats"}
                        }
                        }
                }
                },

                {1021, new Student()
                {StudentId= 1021, Name= "Grumpy Cat",
                        Courses = new List<Course>()
                            {new Course() {CourseId= 106, Name= "Strategic Hisses"},
                            {new Course() {CourseId= 107, Name= "Hiding From Humans"}
                            }
                            }
                }
                },


                {1022, new Student()
                {StudentId= 1022, Name= "Simon's Cat",
                        Courses = new List<Course>()
                            {new Course() {CourseId= 108, Name= "Food Is Love"},
                            {new Course() {CourseId= 109, Name= "Successful Feeding Strategies"}
                            }
                            }
                }
                }

            };


            // purposefully changed the look - but included all required values.
            foreach (var student in students)
            {
                resultLabel.Text += string.Format
                    ("<br/><b>Student: {0}</b> (student ID: {1})<br/>",
                    student.Value.Name, student.Value.StudentId);

                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += string.Format
                        ("&nbsp&nbsp Course: {0} (course ID: {1}<br/>",
                        course.Name, course.CourseId);
                }
            }

            resultLabel.Text += "<br/><br/>";

        }


            
            
            
            
            
            
            protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */


            // cosmetics ...
            resultLabel.Text = "<br/><br/><hr><br/>";


            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    StudentId= 1030, Name= "Tigger", Grades = new List<ReportCard>()
                    {
                        new ReportCard()
                        {
                            Grade= 100, Course= new Course {CourseId= 110, Name= "Jumping Over Barriers"}
                        },
                        new ReportCard()
                        {
                            Grade= 75, Course= new Course {CourseId= 111, Name= "Social Chewing" }
                        }
                    }
                },

                new Student()
                {
                    StudentId= 1031, Name= "Fluffy", Grades = new List<ReportCard>()
                    {
                        new ReportCard()
                        {
                            Grade= 95, Course= new Course {CourseId= 112, Name= "Grooming Basics"}
                        },
                        new ReportCard()
                        {
                            Grade= 90, Course= new Course {CourseId= 114, Name= "Advanced Longhair Grooming Techniques" }
                        }
                    }
                },


                new Student()
                {
                    StudentId= 1032, Name= "Princess", Grades = new List<ReportCard>()
                    {
                        new ReportCard()
                        {
                            Grade= 100, Course= new Course {CourseId= 115, Name= "Taming Human Staff"}
                        },
                        new ReportCard()
                        {
                            Grade= 95, Course= new Course {CourseId= 116, Name= "Advanced Human Management" }
                        }
                    }
                }

            };


            // purposefully changed the look - but included all required values.
            foreach (var student in students)
            {
                resultLabel.Text += string.Format("<br/><br/><b> Student: {0}</b> (student ID: {1})",
                    student.Name, student.StudentId);
                 
                foreach (var grades in student.Grades)
                {
                    resultLabel.Text += string.Format
                        ("<br>&nbsp&nbsp<b> Grade: {0}</b>, Course: {1}, (Course ID: {2})",
                        grades.Grade, grades.Course.Name, grades.Course.CourseId );
                }
            }

            resultLabel.Text += "<br/><br/>";

        }
    }
}