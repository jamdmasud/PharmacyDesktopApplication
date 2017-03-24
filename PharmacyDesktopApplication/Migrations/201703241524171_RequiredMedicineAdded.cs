namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredMedicineAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequiredMedicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineName = c.String(unicode: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RequiredMedicines");
        }
    }
}
