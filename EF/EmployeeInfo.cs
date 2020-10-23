using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EF
{
    public partial class Employee
    {
        public override string ToString()
        {
            return $"{Id}<{Age}<{Salary}<{FName},{LName}";
        }
    }
}
