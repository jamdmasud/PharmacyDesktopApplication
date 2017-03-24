namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class invoiceIdAdding1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DuePayments", "CustomerId", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DuePayments", "CustomerId");
        }
    }
}
