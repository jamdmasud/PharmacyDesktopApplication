using System;

namespace PharmacyDesktopApplication.Entities
{
   public class PurchaseSub
    {
        public string Id { get; set; }
        public string MainId { get; set; }
        public string MedicinId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual PurchaseMain PurchaseMain { get; set; }
    }
}
