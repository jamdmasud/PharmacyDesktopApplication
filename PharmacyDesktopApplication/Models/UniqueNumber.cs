using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDesktopApplication.Models
{
    public class UniqueNumber
    {
        public static string GenerateUniqueNumber()
        {
            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            return number;
        }
    }
}
