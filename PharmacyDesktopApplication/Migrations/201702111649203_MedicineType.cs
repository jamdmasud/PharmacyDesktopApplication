namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MedicineType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicines", "MedicineType", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicines", "MedicineType");
        }
    }
}
