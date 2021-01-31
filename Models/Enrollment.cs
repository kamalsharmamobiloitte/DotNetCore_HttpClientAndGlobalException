using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFOperation.Models
{

    public enum Grade
    {

        A,B,C,D,E,F
    }

    [Table("Enrollments")]
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }


    }
}