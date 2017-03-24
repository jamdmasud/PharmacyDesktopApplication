using System;

namespace PharmacyDesktopApplication.Models
{
    public class Store
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public string Company { get; set; }
        public decimal Purchased { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Sold { get; set; }
        public decimal Balance { get; set; }     

    }
}
