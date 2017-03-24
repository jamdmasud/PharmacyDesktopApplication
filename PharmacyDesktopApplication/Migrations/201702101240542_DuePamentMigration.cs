namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DuePamentMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DuePayments",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedBy = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DuePayments");
        }
    }
}
