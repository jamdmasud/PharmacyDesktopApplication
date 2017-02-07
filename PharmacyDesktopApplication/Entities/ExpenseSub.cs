using System;

namespace PharmacyDesktopApplication.Entities
{
   public class ExpenseSub
    {
        public string Id { get; set; }
        public string MainId { get; set; }
        public decimal Amount { get; set; }
        public string ExpenseType { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ExpenseMain ExpenseMain { get; set; }
        public virtual ExpenseType ExpenseType1 { get; set; }
    }
}
