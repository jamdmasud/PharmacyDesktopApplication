using System;
using System.Linq;
using PharmacyDesktopApplication.Entities;

namespace PharmacyDesktopApplication.Models.InformationFactory
{
   public class GroupFactory
    {
        public static string GetGroupId(string group,  string currentUser)
        {
            PharmacyDbContext db =new PharmacyDbContext();
            var groups = db.Groups.FirstOrDefault(x => x.Name == group);
            if (groups != null) return groups.Id;
            else
            {
                groups = new Groups
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = group,
                    CreatedBy = currentUser,
                    CreatedDate = DateTime.Now
                };

                db.Groups.Add(groups);
                db.SaveChanges();
            }
            return groups.Id;
        }
    }
}
