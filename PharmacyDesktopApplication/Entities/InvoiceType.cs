using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
   public class InvoiceType
    {
        public InvoiceType()
        {
            this.Invoice = new HashSet<Invoice>();
        }

        public string Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
