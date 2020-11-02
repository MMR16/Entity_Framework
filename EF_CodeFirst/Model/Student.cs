using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Model
//Using Convention
{
  public  class Student
    {//PK
        public int StudentId { get; set; }
        public int Age { get; set; }
        public string  Name { get; set; }
        //FK
        public int CourseId { get; set; }
        public virtual ICollection<Course>  Courses{ get; set; }

        public Student()
        {
            Courses = new HashSet<Course>();
        }

    }
}
