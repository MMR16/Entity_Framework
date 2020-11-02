namespace EF_CodeFirst
{
    using EF_CodeFirst.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection;

    public class CompanyContext : DbContext
    {
        // Your context has been configured to use a 'CompanyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EF_CodeFirst.CompanyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CompanyContext' 
        // connection string in the application configuration file.
        public CompanyContext()
            : base("name=CompanyContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
       // public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}