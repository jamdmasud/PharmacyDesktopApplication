using System.Data.Entity;

namespace PharmacyDesktopApplication.Entities
{
    public class PharmacyDbContext : DbContext
    {
        public PharmacyDbContext(): base("PharmacyDbContext")
        {
        }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<ExpenseMain> ExpenseMain { get; set; }
        public virtual DbSet<ExpenseSub> ExpenseSub { get; set; }
        public virtual DbSet<ExpenseType> ExpenseType { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceType> InvoiceType { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<PurchaseMain> PurchaseMain { get; set; }
        public virtual DbSet<PurchaseSub> PurchaseSub { get; set; }
        public virtual DbSet<SaleMain> SaleMain { get; set; }
        public virtual DbSet<SaleSub> SaleSub { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
