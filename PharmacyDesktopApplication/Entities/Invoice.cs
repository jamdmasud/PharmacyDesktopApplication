using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
    public class Invoice
    {
        public Invoice()
        {
            this.ExpenseMain = new HashSet<ExpenseMain>();
            this.PurchaseMain = new HashSet<PurchaseMain>();
            this.SaleMain = new HashSet<SaleMain>();
            this.Voucher = new HashSet<Voucher>();
        }

        public string Id { get; set; }
        public string InvoiceType { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<ExpenseMain> ExpenseMain { get; set; }
        public virtual InvoiceType InvoiceType1 { get; set; }
        public virtual ICollection<PurchaseMain> PurchaseMain { get; set; }
        public virtual ICollection<SaleMain> SaleMain { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
    }
}
