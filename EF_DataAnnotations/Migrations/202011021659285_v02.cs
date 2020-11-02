namespace EF_DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v02 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "DeptLocation");
            DropColumn("dbo.Departments", "Description");
            DropColumn("dbo.Employees", "any");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "any", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "Description", c => c.String());
            AddColumn("dbo.Departments", "DeptLocation", c => c.String(nullable: false));
        }
    }
}
