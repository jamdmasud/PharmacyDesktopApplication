using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
    public class ExpenseMain
    {
        public ExpenseMain()
        {
            this.ExpenseSub = new HashSet<ExpenseSub>();
        }

        public string Id { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public string InvoiceId { get; set; }
        public string Note { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Invoice Invoice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseSub> ExpenseSub { get; set; }
    }
}
