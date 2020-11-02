using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Model
//Using Convention
{
   public class Department
    {//PK
        public int DepartmentId { get; set; }
        public string DeptName { get; set; }

        //Navigation Property
        ///Many to One
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        
        //public Department()
        //{
        //    Employees = new HashSet<Employee>();
        //}
    }
}
