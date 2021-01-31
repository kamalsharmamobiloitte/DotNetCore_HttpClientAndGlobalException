using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFOperation.Models
{
    [Table("Courses")]
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credit { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
