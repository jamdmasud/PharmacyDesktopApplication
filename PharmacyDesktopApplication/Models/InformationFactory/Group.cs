using System;
using System.Linq;
using PharmacyDesktopApplication.Entities;

namespace PharmacyDesktopApplication.Models.InformationFactory
{
   public class Group
    {
        public static string GetGroupId(string group, PharmacyDbContext db, string currentUser)
        {
            var groups = db.Groups.FirstOrDefault(x => x.Name == group);
            if (groups != null) return groups.Id;
            else
            {
                groups = new Groups
                {
                    Id = UniqueNumber.GenerateUniqueNumber(),
                    Name = group,
                    CreatedBy = currentUser,
                    CreatedDate = DateTime.Now
                };

                db.Groups.Add(groups);
            }
            return groups.Id;
        }
    }
}
