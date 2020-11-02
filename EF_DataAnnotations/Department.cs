using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DataAnnotations
{
    public class Department
    {
        [Key]
        public int DepID { get; set; }
        [Required]
        public string DeptName { get; set; }
        //[Required]
        //public string DeptLocation { get; set; }
        //public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
