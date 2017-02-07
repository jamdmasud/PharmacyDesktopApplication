using System;
using System.Collections.Generic;

namespace PharmacyDesktopApplication.Entities
{
   public class Groups
    {
        public Groups()
        {
            this.Medicine = new HashSet<Medicine>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<Medicine> Medicine { get; set; }
    }
    
}
