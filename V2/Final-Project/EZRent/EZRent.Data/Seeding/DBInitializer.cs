using EZRent.Data.Database;
using EZRent.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EZRent.Data.Seeding
{
    public static class DBInitializer
    {
        public static void Init(ApplicationUserDbContext appUserDbContext, EZRentDbContext eZRentDbContext)
        {
            appUserDbContext.Database.Migrate();
            eZRentDbContext.Database.Migrate();
            // if there are no roles
            if (!appUserDbContext.Roles.Any())
            {
                // add them
                AddRoles(appUserDbContext);
            }

            // Lease type
            if (!eZRentDbContext.LeaseTypes.Any())
            {
                AddLeaseType(eZRentDbContext);
            }
        }

        // Lease Type
        private static void AddLeaseType(EZRentDbContext eZRentDbContext)
        {
            string[] types = new string[] { "Month-to-Month", "Fixed Term" };

            foreach(var t in types)
            {
                var newType = new LeaseType
                {
                    Description = t
                };

                eZRentDbContext.LeaseTypes.Add(newType);
            }
            eZRentDbContext.SaveChanges();
        }

        // Maintenance Status
        private static void AddMaintenanceStatus(EZRentDbContext eZRentDbContext)
        {
            string[] types = new string[] { "New", "Fixed","In-Progress", "Not a defect" };

            foreach (var t in types)
            {
                var newType = new MaintenanceStatus
                {
                    Description = t
                };

                eZRentDbContext.MaintenanceStatuses.Add(newType);
            }
            eZRentDbContext.SaveChanges();
        }
        // Payment Status

        // Property Type


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
