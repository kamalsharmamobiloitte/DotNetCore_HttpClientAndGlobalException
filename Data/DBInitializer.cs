using EFOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFOperation.Data
{
    public static class DBInitializer

    {

        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            var students = new Student[] {
                new Student { FirstName = "Carson", LastName = "Alexander", EnrolledDate = DateTime.Parse("2005-09-01") },
                new Student { FirstName = "Meredith", LastName = "Alonso", EnrolledDate = DateTime.Parse("2002-09-01") },
                new Student { FirstName = "Arturo", LastName = "Anand", EnrolledDate = DateTime.Parse("2003-09-01") },
                new Student { FirstName = "Gytis", LastName = "Barzdukas", EnrolledDate = DateTime.Parse("2002-09-01") },
                new Student { FirstName = "Yan", LastName = "Li", EnrolledDate = DateTime.Parse("2002-09-01") },
                new Student { FirstName = "Peggy", LastName = "Justice", EnrolledDate = DateTime.Parse("2001-09-01") },
                new Student { FirstName = "Laura", LastName = "Norman", EnrolledDate = DateTime.Parse("2003-09-01") },
                new Student { FirstName = "Nino", LastName = "Olivetto", EnrolledDate = DateTime.Parse("2005-09-01") } };
            foreach (Student s in students) { context.Students.Add(s); }
            context.SaveChanges();
            var courses = new Course[] { new Course { CourseID = 1050, Title = "Chemistry", Credit = 3 },
                new Course { CourseID = 4022, Title = "Microeconomics", Credit = 3 },
                new Course { CourseID = 4041, Title = "Macroeconomics", Credit = 3 },
                new Course { CourseID = 1045, Title = "Calculus", Credit = 4 },
                new Course { CourseID = 3141, Title = "Trigonometry", Credit = 4 },
                new Course { CourseID = 2021, Title = "Composition", Credit = 3 },
                new Course { CourseID = 2042, Title = "Literature", Credit = 4 } };
            foreach (Course c in courses) { context.Courses.Add(c); }
            context.SaveChanges();
            var enrollments = new Enrollment[]            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F },
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},            };
            foreach (Enrollment e in enrollments) { context.Enrollments.Add(e); }
            context.SaveChanges();

        }
    }
}
