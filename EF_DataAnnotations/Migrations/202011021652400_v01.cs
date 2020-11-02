namespace EF_DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepID = c.Int(nullable: false, identity: true),
                        DeptName = c.String(nullable: false),
                        DeptLocation = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.DepID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        SSN = c.Int(nullable: false),
                        FirstName = c.String(name: "First Name", nullable: false, maxLength: 10),
                        LastName = c.String(name: "Last Name", maxLength: 10),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Age = c.Int(),
                        Salary = c.Decimal(storeType: "money"),
                        Birthday = c.DateTime(storeType: "date"),
                        Adress = c.String(),
                        any = c.Int(nullable: false),
                        ADepID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SSN)
                .ForeignKey("dbo.Departments", t => t.ADepID, cascadeDelete: true)
                .Index(t => t.ADepID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ADepID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "ADepID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
