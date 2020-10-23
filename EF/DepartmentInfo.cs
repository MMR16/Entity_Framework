using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public partial class Department
    {
        public override string ToString()
        {
            return $",{DeptId},{DeptName}";
        }
    }
}
