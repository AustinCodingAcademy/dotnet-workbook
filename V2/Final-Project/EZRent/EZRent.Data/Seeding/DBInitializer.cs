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

            if (!appUserDbContext.Roles.Any())
            {
                AddRoles(appUserDbContext);
            }

            if (!eZRentDbContext.LeaseTypes.Any())
            {
                AddLeaseType(eZRentDbContext);
            }

            if (!eZRentDbContext.PropertyTypes.Any())
            {
                AddPropertyTypes(eZRentDbContext);
            }

            if (!eZRentDbContext.PaymentStatuses.Any())
            {
                AddPaymentStatuses(eZRentDbContext);
            }

            if (!eZRentDbContext.MaintenanceStatuses.Any())
            {
                AddMaintenanceStatus(eZRentDbContext);
            }
        }

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


        private static void AddPaymentStatuses(EZRentDbContext eZRentDbContext)
        {
            string[] statuses = new string[] { "Paid", "Processing", "Due", "Overdue" };

            foreach(var p in statuses)
            {
                var newPaymentStatus = new PaymentStatus
                {
                    Description = p
                };

                eZRentDbContext.PaymentStatuses.Add(newPaymentStatus);
            }

            eZRentDbContext.SaveChanges();
        }


        private static void AddPropertyTypes(EZRentDbContext ezRentDbContext)
        {
            string[] types = new string[] { "Apartment", "Single Family Home", "Duplex/Triplex/Townhouse", "Mobile", "Dormitory", "Commercial" };

            foreach(var t in types)
            {
                var newPropertyType = new PropertyType
                {
                    Description = t
                };

                ezRentDbContext.PropertyTypes.Add(newPropertyType);
            }
            ezRentDbContext.SaveChanges();
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
