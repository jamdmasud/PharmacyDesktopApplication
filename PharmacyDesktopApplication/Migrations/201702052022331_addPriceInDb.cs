namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPriceInDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicines", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicines", "UnitPrice");
        }
    }
}
