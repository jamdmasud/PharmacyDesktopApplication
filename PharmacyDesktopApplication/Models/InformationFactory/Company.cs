using System;
using System.Linq;
using PharmacyDesktopApplication.Entities;

namespace PharmacyDesktopApplication.Models.InformationFactory
{
    public class Company
    {
        public static string GetCompanyId(string company,  string currentUser)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            var companys = db.Company.FirstOrDefault(x => x.Name == company);
            if (companys != null) return companys.Id;
            else
            {
                companys = new Entities.Company()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = company,
                    CreatedBy = currentUser,
                    CreatedDate = DateTime.Now
                };
                db.Company.Add(companys);
                db.SaveChanges();
            }
            return companys.Id;
        }
    }
}
