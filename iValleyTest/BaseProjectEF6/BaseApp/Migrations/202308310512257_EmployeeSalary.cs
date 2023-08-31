namespace BaseApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeSalary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeSalaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalaryDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeSalaries", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.EmployeeSalaries", new[] { "EmployeeID" });
            DropTable("dbo.EmployeeSalaries");
        }
    }
}
