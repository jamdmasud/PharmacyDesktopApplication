using System;
using System.Linq;
using PharmacyDesktopApplication.Entities;

namespace PharmacyDesktopApplication.Models.InformationFactory
{
    public class Company
    {
        public static string GetCompanyId(string company, PharmacyDbContext db, string currentUser)
        {
            var companys = db.Company.FirstOrDefault(x => x.Name == company);
            if (companys != null) return companys.Id;
            else
            {
                companys = new Entities.Company()
                {
                    Id = UniqueNumber.GenerateUniqueNumber(),
                    Name = company,
                    CreatedBy = currentUser,
                    CreatedDate = DateTime.Now
                };

                db.Company.Add(companys);
            }
            return companys.Id;
        }
    }
}
