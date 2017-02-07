using System;

namespace PharmacyDesktopApplication.Entities
{
   public class Voucher
    {
        public string Id { get; set; }
        public int EntryNo { get; set; }
        public string InvoiceId { get; set; }
        public string GLCode { get; set; }
       public decimal Dr { get; set; }
       public decimal Cr { get; set; }
        public string Note { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
