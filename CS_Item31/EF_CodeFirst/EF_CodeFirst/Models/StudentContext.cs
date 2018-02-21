using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_CodeFirst.Models
{
    // Context is EF magic ...

    public class StudentContext : DbContext
    {
        // ctor:
        public StudentContext() : base("StudentDatabase")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}