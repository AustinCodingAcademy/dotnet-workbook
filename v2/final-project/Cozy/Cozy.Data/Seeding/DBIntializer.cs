using Cozy.Data.Database;
using Cozy.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cozy.Data.Seeding
{
    public static class DBIntializer
    {
        public static void Init(ApplicationUserDbContext applicationUserDbContext, CozyDbContext cozyDbContext)
        {
            // Check if the DB is created
            applicationUserDbContext.Database.Migrate();
            cozyDbContext.Database.Migrate();

            // Add roles if there are none
            if (!applicationUserDbContext.Roles.Any())
            {
                AddRoles(applicationUserDbContext);
            }

            // Lease Type
            if(!cozyDbContext.LeaseTypes.Any())
            {
                AddLeaseTypes(cozyDbContext);
            }
        }

        private static void AddLeaseTypes(CozyDbContext cozyDbContext)
        {
            string[] types = new string[] { "Month-To-Month", "Fixed Term" };

            foreach(var t in types)
            {
                var newType = new LeaseType
                {
                    Description = t
                };

                cozyDbContext.LeaseTypes.Add(newType);
            }

            cozyDbContext.SaveChanges();
        }

        public static void AddRoles(ApplicationUserDbContext applicationUserDbContext)
        {
            string[] roles = new string[] { "Landlord", "Tenant" };

            foreach(var r in roles)
            {
                var newRole = new IdentityRole
                {
                    Name = r,
                    NormalizedName = r.ToUpper()
                };

                applicationUserDbContext.Roles.Add(newRole);
            }

            applicationUserDbContext.SaveChanges();
        }
    }
}
