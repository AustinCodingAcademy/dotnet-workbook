using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCoreLeaseServices : ILeaseServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCoreLeaseServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Lease CreateLease(Lease newLease)
        {
            _dbContext.Leases.Add(newLease);
            _dbContext.SaveChanges();

            return newLease;
        }

        public bool DeleteLease(int propertyId, int tenantId)
        {
            var lease = _dbContext.Leases.Find(propertyId, tenantId);
            _dbContext.Leases.Remove(lease);

            if(_dbContext.Leases.Find(propertyId, tenantId) == null)
            {
                return true;
            }

            return false;
        }

        public Lease GetLeaseByPropertyIdAndTenantId(int propertyId, int tenantId)
        {
            return _dbContext.Leases.Find(propertyId, tenantId);
        }

        public Lease UpdateLease(Lease updatedLease)
        {
            var lease = _dbContext.Leases.Update(updatedLease);
            _dbContext.SaveChanges();

            return lease.Entity;
        }
    }
}
