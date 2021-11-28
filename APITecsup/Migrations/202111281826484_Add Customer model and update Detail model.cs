namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomermodelandupdateDetailmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Details", "IGV", c => c.Int(nullable: false));
            AddColumn("dbo.Details", "Total", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Invoices", "Customer_Id");
            AddForeignKey("dbo.Invoices", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Invoices", new[] { "Customer_Id" });
            DropColumn("dbo.Invoices", "Customer_Id");
            DropColumn("dbo.Details", "Total");
            DropColumn("dbo.Details", "IGV");
            DropTable("dbo.Customers");
        }
    }
}
