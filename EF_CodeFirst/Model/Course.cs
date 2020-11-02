using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Model
//Using Convention
{
   public class Course
    {//PK
        public int CourseId { get; set; }
        public string CourceName { get; set; }

        //FK
        public int StudentId { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Course()
        {
            Students = new HashSet<Student>();
        }
    }
}
