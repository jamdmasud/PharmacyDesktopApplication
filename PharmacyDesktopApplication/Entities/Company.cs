using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
    public class Company
    {
        public Company()
        {
            this.Medicine = new HashSet<Medicine>();
            this.PurchaseMain = new HashSet<PurchaseMain>();
            this.Voucher = new HashSet<Voucher>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Volume { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<Medicine> Medicine { get; set; }
        public virtual ICollection<PurchaseMain> PurchaseMain { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
    }
}
