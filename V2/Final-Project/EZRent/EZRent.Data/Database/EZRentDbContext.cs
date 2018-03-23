using EZRent.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Data.Database
{
    public class EZRentDbContext : DbContext
    {
        // No AppUser, Landlord, or Tenant
        public DbSet<Bank> Banks {get; set;}
        public DbSet<Lease> Leases { get; set; }
        public DbSet<LeaseType> LeaseTypes { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<MaintenanceStatus> MaintenanceStatuses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }

        public EZRentDbContext(DbContextOptions<EZRentDbContext> options) 
            : base(options)
        {

        }
        
    }
}
