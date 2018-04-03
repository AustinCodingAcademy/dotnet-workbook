using Cozy.Data.Database;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace Cozy.Data.Seeding
{
    public static class DBInitializer
    {
        public static void Init(ApplicationUserDbContext appUserDbContext)
        {
            // check of the db is create
            appUserDbContext.Database.EnsureCreated();

            // if there are none roles
            if (!appUserDbContext.Roles.Any())
            {
                AddRoles(appUserDbContext);
            }
            
            // check for more stuff in future
            // and add them as you need
        }

        public static void AddRoles(ApplicationUserDbContext appUserDbContext)
        {
            string[] roles = new string[] { "Landlord", "Tenant" };

            foreach(var r in roles)
            {
                var newRole = new IdentityRole
                {
                    Name = r,
                    NormalizedName = r.ToUpper()
                };

                appUserDbContext.Roles.Add(newRole);
            }

            appUserDbContext.SaveChanges();
        }
    }
}
