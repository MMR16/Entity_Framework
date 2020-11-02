using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace EF_DataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<CompanyContext>());
            CompanyContext Db = new CompanyContext();
            //Db.Departments.Add(new Department() { DeptName = "FullStack" });
            //Db.Departments.Add(new Department() { DeptName = "IOS" });
            //Db.Departments.Add(new Department() { DeptName = "Python" });
            //Db.Departments.Add(new Department() { DeptName = "IOT" });

            //Db.Employees.Add(new Employee() {SSN=100,Age=26,Fname="Mostafa",Lname="Mahmoud",Adress="agazig",Phone=01150369623,Birthday=new DateTime(1994,03,16),ADepID=1,Salary=10000,Email="MMR16rady@yahoo.com" });
            //Db.SaveChanges();

            var emps = Db.Employees.Include("Department").ToList();
            foreach (var item in emps)
            {
                Console.WriteLine(item.Fname+" "+item.Department.DeptName);
            }

            Console.ReadKey();
        }
    }
}
