using Cozy.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cozy.Data.Database
{
    public class CozyDbContext : DbContext
    {
        // No AppUser, Landlord, or tenant

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<LeaseType> LeaseTypes { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<MaintenanceStatus> MaintenanceStatuses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }

        public CozyDbContext(DbContextOptions<CozyDbContext> options)
            : base(options)
        {

        }
    }
}
