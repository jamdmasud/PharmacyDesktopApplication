namespace PharmacyDesktopApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Mobile = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenseMains",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InvoiceId = c.String(maxLength: 128, unicode: false),
                        Note = c.String(unicode: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        AppUser_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId)
                .Index(t => t.InvoiceId)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.ExpenseSubs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        MainId = c.String(unicode: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseType = c.String(unicode: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        ExpenseMain_Id = c.String(maxLength: 128, unicode: false),
                        ExpenseType1_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseMains", t => t.ExpenseMain_Id)
                .ForeignKey("dbo.ExpenseTypes", t => t.ExpenseType1_Id)
                .Index(t => t.ExpenseMain_Id)
                .Index(t => t.ExpenseType1_Id);
            
            CreateTable(
                "dbo.ExpenseTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Type = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        InvoiceType = c.String(unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        InvoiceType1_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InvoiceTypes", t => t.InvoiceType1_Id)
                .Index(t => t.InvoiceType1_Id);
            
            CreateTable(
                "dbo.InvoiceTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        TypeName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseMains",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GrandTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DuePaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyId = c.String(maxLength: 128, unicode: false),
                        Note = c.String(unicode: false),
                        InvoiceId = c.String(maxLength: 128, unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        updatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId)
                .Index(t => t.CompanyId)
                .Index(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        Volume = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(unicode: false),
                        GroupId = c.String(unicode: false),
                        CompanyId = c.String(maxLength: 128, unicode: false),
                        ExpiredDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        Groups_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Groups", t => t.Groups_Id)
                .Index(t => t.CompanyId)
                .Index(t => t.Groups_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseSubs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        MainId = c.String(unicode: false),
                        MedicinId = c.String(unicode: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        Medicine_Id = c.String(maxLength: 128, unicode: false),
                        PurchaseMain_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.Medicine_Id)
                .ForeignKey("dbo.PurchaseMains", t => t.PurchaseMain_Id)
                .Index(t => t.Medicine_Id)
                .Index(t => t.PurchaseMain_Id);
            
            CreateTable(
                "dbo.SaleSubs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        MainId = c.String(unicode: false),
                        MedicinId = c.String(unicode: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        Medicine_Id = c.String(maxLength: 128, unicode: false),
                        SaleMain_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.Medicine_Id)
                .ForeignKey("dbo.SaleMains", t => t.SaleMain_Id)
                .Index(t => t.Medicine_Id)
                .Index(t => t.SaleMain_Id);
            
            CreateTable(
                "dbo.SaleMains",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GrandTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DuePaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.String(maxLength: 128, unicode: false),
                        InvoiceId = c.String(maxLength: 128, unicode: false),
                        Note = c.String(unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        updatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId)
                .Index(t => t.CustomerId)
                .Index(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(unicode: false),
                        Mobile = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vouchers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        EntryNo = c.Int(nullable: false),
                        InvoiceId = c.String(maxLength: 128, unicode: false),
                        GLCode = c.String(unicode: false),
                        Dr = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cr = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(unicode: false),
                        CompanyId = c.String(maxLength: 128, unicode: false),
                        CustomerId = c.String(maxLength: 128, unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId)
                .Index(t => t.InvoiceId)
                .Index(t => t.CompanyId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseMains", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.PurchaseMains", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.SaleSubs", "SaleMain_Id", "dbo.SaleMains");
            DropForeignKey("dbo.SaleMains", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Vouchers", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Vouchers", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Vouchers", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.SaleMains", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.SaleSubs", "Medicine_Id", "dbo.Medicines");
            DropForeignKey("dbo.PurchaseSubs", "PurchaseMain_Id", "dbo.PurchaseMains");
            DropForeignKey("dbo.PurchaseSubs", "Medicine_Id", "dbo.Medicines");
            DropForeignKey("dbo.Medicines", "Groups_Id", "dbo.Groups");
            DropForeignKey("dbo.Medicines", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Invoices", "InvoiceType1_Id", "dbo.InvoiceTypes");
            DropForeignKey("dbo.ExpenseMains", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.ExpenseSubs", "ExpenseType1_Id", "dbo.ExpenseTypes");
            DropForeignKey("dbo.ExpenseSubs", "ExpenseMain_Id", "dbo.ExpenseMains");
            DropForeignKey("dbo.ExpenseMains", "AppUser_Id", "dbo.AppUsers");
            DropIndex("dbo.Vouchers", new[] { "CustomerId" });
            DropIndex("dbo.Vouchers", new[] { "CompanyId" });
            DropIndex("dbo.Vouchers", new[] { "InvoiceId" });
            DropIndex("dbo.SaleMains", new[] { "InvoiceId" });
            DropIndex("dbo.SaleMains", new[] { "CustomerId" });
            DropIndex("dbo.SaleSubs", new[] { "SaleMain_Id" });
            DropIndex("dbo.SaleSubs", new[] { "Medicine_Id" });
            DropIndex("dbo.PurchaseSubs", new[] { "PurchaseMain_Id" });
            DropIndex("dbo.PurchaseSubs", new[] { "Medicine_Id" });
            DropIndex("dbo.Medicines", new[] { "Groups_Id" });
            DropIndex("dbo.Medicines", new[] { "CompanyId" });
            DropIndex("dbo.PurchaseMains", new[] { "InvoiceId" });
            DropIndex("dbo.PurchaseMains", new[] { "CompanyId" });
            DropIndex("dbo.Invoices", new[] { "InvoiceType1_Id" });
            DropIndex("dbo.ExpenseSubs", new[] { "ExpenseType1_Id" });
            DropIndex("dbo.ExpenseSubs", new[] { "ExpenseMain_Id" });
            DropIndex("dbo.ExpenseMains", new[] { "AppUser_Id" });
            DropIndex("dbo.ExpenseMains", new[] { "InvoiceId" });
            DropTable("dbo.Vouchers");
            DropTable("dbo.Customers");
            DropTable("dbo.SaleMains");
            DropTable("dbo.SaleSubs");
            DropTable("dbo.PurchaseSubs");
            DropTable("dbo.Groups");
            DropTable("dbo.Medicines");
            DropTable("dbo.Companies");
            DropTable("dbo.PurchaseMains");
            DropTable("dbo.InvoiceTypes");
            DropTable("dbo.Invoices");
            DropTable("dbo.ExpenseTypes");
            DropTable("dbo.ExpenseSubs");
            DropTable("dbo.ExpenseMains");
            DropTable("dbo.AppUsers");
        }
    }
}
