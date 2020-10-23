using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD Operations

            //Creating Opject From Class Inherits Class DbContext
            DataContextContainer DB = new DataContextContainer();
            #region Create Adding Data To DataBase 

            //Department D1 = new Department() { DeptName = "FullStack" };
            //Department D2 = new Department() { DeptName = "IOS" };
            //Department D3 = new Department() { DeptName = "Java" };
            //Department D4 = new Department() { DeptName = "Python" };

            ////Using forignKey DepartmentDeptId  (the best way)
            //Employee E1 = new Employee() { FName = "Mostafa", LName = "Mahmoud", Age = 26, Salary = 5000, DepartmentDeptId = 1 };
            ////Using forignKey Department navigator
            //Employee E2 = new Employee() { FName = "alaa", LName = "Mahmoud", Age = 30, Salary = 4000, Department = D3 };
            //Employee E3 = new Employee() { FName = "Ahmed", LName = "Mahmoud", Age = 34, Salary = 6000, DepartmentDeptId = 2 };

            ////using addrange
            //DB.Departments.AddRange(new Department[] { D1, D2, D3, D4 });
            ////using add
            //DB.Employees.Add(E1);
            //DB.Employees.Add(E2);
            //DB.Employees.Add(E3);
            //// to apply add-update-delete
            //DB.SaveChanges(); 
            #endregion

            #region Read Data Select
            //var Emp3 = DB.Employees.FirstOrDefault(w => w.Id == 3);
            //Console.WriteLine(Emp3);
            //Console.WriteLine();

            //get all employees
            //var employees = DB.Employees.ToList();
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //var Employees = DB.Employees.Where(w => w.Age > 20);
            //foreach (var item in Employees)
            //{
            //Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //var emp = DB.Employees.Select(w=> new { Age = w.Age, name = w.FName });
            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //var employee_deptName = Emp3.Department.DeptName;
            //Console.WriteLine(employee_deptName);

            //var emps = DB.Employees.Include(w => w.Department).ToList();

            //var emp2 = DB.Employees.ToList();

            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item.FName + " " + item.Department.DeptName);
            //}
            //Console.WriteLine("*************");
            //foreach (var item in emp2)
            //{
            //    Console.WriteLine(item.FName + " " + item.Department.DeptName);
            //}

            //var emp = DB.Employees.Where(w => w.FName.ToLower().Contains("o")).ToList();
            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item);
            //}

            //var emp = DB.Employees.Select(w => new { name = w.FName + "  " + w.LName, Department = w.Department.DeptName }).ToList();
            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Update
            // //exception if duplicated
            // var Upd = DB.Employees.Single(w => w.Id == 2);
            //// var Upd3 = DB.Employees.First(w => w.Id == 600);
            // //no exception 
            // var Upd2 = DB.Employees.SingleOrDefault(w => w.Id == 200);
            // var Upd4 = DB.Employees.FirstOrDefault(w => w.Id == 100);

            //// Upd4.Age = 66; //error here not in first or default

            // Upd.FName = "Asmaa";
            // Upd.Salary = 7000;
            // Upd.Age = 24;
            // Upd.DepartmentDeptId = 3;
            // DB.SaveChanges();
            #endregion

            #region Delete
            //var emp = DB.Employees.Single(w => w.Id == 3);
            ////remove   from ram / local storage
            //DB.Employees.Remove(emp);
            //DB.SaveChanges();
            #endregion

            Console.ReadKey();
        }
    }
}
