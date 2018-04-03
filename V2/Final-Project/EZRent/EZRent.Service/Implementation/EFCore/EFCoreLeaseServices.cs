using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCoreLeaseServices :ILeaseServices
    {
        private readonly EZRentDbContext _dbcontext;

        public EFCoreLeaseServices(EZRentDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public Lease CreateLease(Lease newLease)
        {
            _dbcontext.Leases.Add(newLease);
            _dbcontext.SaveChanges();

            return newLease;
        }

        public bool DeleteLease(int propertyId, string tenantId)
        {
            var lease = _dbcontext.Leases.Find(propertyId, tenantId);
            _dbcontext.Leases.Remove(lease);

            if(_dbcontext.Leases.Find(propertyId, tenantId) == null)
            {
                return true;
            }

            return false;
        }

        public Lease GetLeaseByPropertyAndTenantId(int propertyId, string tenantId)
        {
            return _dbcontext.Leases.Find(propertyId, tenantId);
        }

        public Lease UpdateLease(Lease updatedLease)
        {
            var lease = _dbcontext.Leases.Update(updatedLease);
            _dbcontext.SaveChanges();

            return lease.Entity;
        }
    }
}
