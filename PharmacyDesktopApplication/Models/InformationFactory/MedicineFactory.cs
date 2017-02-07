using System.Linq;
using PharmacyDesktopApplication.Entities;

namespace PharmacyDesktopApplication.Models.InformationFactory
{
    public class MedicineFactory
    {
        public static string GetMedicineIdByName(string medicineName, PharmacyDbContext db)
        {
            return db.Medicine.Where(o => o.Name == medicineName).Select(s => s.Id).FirstOrDefault();
        }
    }
}
