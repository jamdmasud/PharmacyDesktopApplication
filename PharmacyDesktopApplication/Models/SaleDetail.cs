using System;

namespace PharmacyDesktopApplication.Models
{
    public class SaleDetail
    {
        public int Sl { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public decimal PaidDue { get; set; }
        public DateTime Date { get; set; }
    }
}
