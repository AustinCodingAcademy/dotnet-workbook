using EZRent.Data.Databse;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Data.Seeding
{
    public static class DBInitializer
    {
        public static void Init(ApplicationUserDbContext appUserDbContext)
        {
            // check if the db is created
            appUserDbContext.Database.EnsureCreated();
            // if there are no roles
            if (!appUserDbContext.Roles.Any())
            {
                // add them
                AddRoles(appUserDbContext);
            }
        }

        public static void AddRoles(ApplicationUserDbContext appUserDbContext)
        {
            string[] roles = new string[] { "Landlord", "Tenant" };

            foreach(var r in roles)
            {
                var newrole = new IdentityRole
                {
                    Name = r,
                    NormalizedName = r.ToUpper()
                };

                appUserDbContext.Roles.Add(newrole);
            }
            appUserDbContext.SaveChanges();
        }
    }
}
