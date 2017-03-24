namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class invoiceIdAdding : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DuePayments", "InvoiceId", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DuePayments", "InvoiceId");
        }
    }
}
