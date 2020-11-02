using EF_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    //Using Convention
    class Program
    {
        static void Main(string[] args)
        {
            CompanyContext Db = new CompanyContext();
            Db.Departments.Add(new Department{DeptName="FullStack"});
            Db.SaveChanges();
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
