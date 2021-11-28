namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerentityandupdateDetail : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Details", "IGV", c => c.Double(nullable: false));
            AlterColumn("dbo.Details", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Details", "Total", c => c.Int(nullable: false));
            AlterColumn("dbo.Details", "IGV", c => c.Int(nullable: false));
        }
    }
}
