using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
    public class AppUser
    {
        public AppUser()
        {
            this.ExpenseMain = new HashSet<ExpenseMain>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public virtual ICollection<ExpenseMain> ExpenseMain { get; set; }
    }
}
