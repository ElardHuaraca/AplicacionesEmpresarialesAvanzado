namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddcustomerIDtoDetail : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoices", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Invoices", new[] { "Customer_Id" });
            RenameColumn(table: "dbo.Invoices", name: "Customer_Id", newName: "CustomerID");
            AlterColumn("dbo.Invoices", "CustomerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Invoices", "CustomerID");
            AddForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Invoices", new[] { "CustomerID" });
            AlterColumn("dbo.Invoices", "CustomerID", c => c.Int());
            RenameColumn(table: "dbo.Invoices", name: "CustomerID", newName: "Customer_Id");
            CreateIndex("dbo.Invoices", "Customer_Id");
            AddForeignKey("dbo.Invoices", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
