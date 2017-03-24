namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "CreatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
