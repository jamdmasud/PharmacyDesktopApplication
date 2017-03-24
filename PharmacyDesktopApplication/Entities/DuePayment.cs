using System;

namespace PharmacyDesktopApplication.Entities
{
   public class DuePayment
    {
       public string Id { get; set; }
       public decimal Amount { get; set; }
       public string CustomerId { get; set; }   
       public string InvoiceId { get; set; }
       public string CreatedBy { get; set; }
       public DateTime CreatedDate { get; set; }
    }
}
