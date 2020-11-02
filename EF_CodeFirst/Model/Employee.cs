using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Model
//Using Convention
{
   public class Employee
    {//PK
        public int Id { get; set; }
        public int Age { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
        //FK
        public int DepartmentId { get; set; }
        ///NAVIGATION PROPERTY
        ///one to many
        public virtual Department Department { get; set; }
    }
}
