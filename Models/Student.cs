using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFOperation.Models
{
    [Table("Student")]
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime EnrolledDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
