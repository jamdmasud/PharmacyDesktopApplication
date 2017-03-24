using System;
using System.ComponentModel.DataAnnotations;

namespace PharmacyDesktopApplication.Models
{
   public class PurchaseList
    {
       public string SL { get; set; }
       public string MedicineName { get; set; }
       public decimal Quantity { get; set; }
       public decimal UnitPrice { get; set; }
       public decimal Total { get; set; }
       public string Date { get; set; }
    }
}
