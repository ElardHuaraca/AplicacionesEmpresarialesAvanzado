namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Invoices", new[] { "CustomerID" });
            AlterColumn("dbo.Invoices", "Total", c => c.Int(nullable: false));
            DropColumn("dbo.Details", "IGV");
            DropColumn("dbo.Details", "Total");
            DropColumn("dbo.Invoices", "CustomerID");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Invoices", "CustomerID", c => c.Int(nullable: false));
            AddColumn("dbo.Details", "Total", c => c.Double(nullable: false));
            AddColumn("dbo.Details", "IGV", c => c.Double(nullable: false));
            AlterColumn("dbo.Invoices", "Total", c => c.Double(nullable: false));
            CreateIndex("dbo.Invoices", "CustomerID");
            AddForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
