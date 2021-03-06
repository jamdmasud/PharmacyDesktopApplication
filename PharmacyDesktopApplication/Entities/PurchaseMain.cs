﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDesktopApplication.Entities
{
    public class PurchaseMain
    {
        public PurchaseMain()
        {
            this.PurchaseSub = new HashSet<PurchaseSub>();
        }

        public string Id { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public decimal DuePaid { get; set; }
        public decimal vat { get; set; }
        public string CompanyId { get; set; }
        public string Note { get; set; }
        public string InvoiceId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime updatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<PurchaseSub> PurchaseSub { get; set; }
    }
}
