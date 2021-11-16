namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentId = c.Int(nullable: false, identity: true),
                        studentName = c.String(nullable: false),
                        studentAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.studentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
