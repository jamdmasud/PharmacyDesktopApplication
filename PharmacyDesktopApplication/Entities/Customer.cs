using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
   public class Customer
    {
        public Customer()
        {
            this.SaleMain = new HashSet<SaleMain>();
            this.Voucher = new HashSet<Voucher>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<SaleMain> SaleMain { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
    }
}
