using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
    public class Medicine
    {
        public Medicine()
        {
            this.PurchaseSub = new HashSet<PurchaseSub>();
            this.SaleSub = new HashSet<SaleSub>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string GroupId { get; set; }
        public string CompanyId { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string MedicineType { set; get; }
        public decimal UnitPrice { get; set; }  
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual ICollection<PurchaseSub> PurchaseSub { get; set; }
        public virtual ICollection<SaleSub> SaleSub { get; set; }
    }
}
