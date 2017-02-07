using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
    public class ExpenseType
    {
        public ExpenseType()
        {
            this.ExpenseSub = new HashSet<ExpenseSub>();
        }

        public string Id { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<ExpenseSub> ExpenseSub { get; set; }
    }
}
