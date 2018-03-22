using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockLeaseServices : ILeaseServices
    {
        private List<Lease> _context;

        public MockLeaseServices()
        {
            _context = MockLease.list;
        }

        public Lease CreateLease(Lease newLease)
        {
            _context.Add(newLease);
            return newLease;
        }

        public bool DeleteLease(int propertyId, int tenantId)
        {
            Lease l = GetLeaseByPropertyIdAndTenantId(propertyId, tenantId);
            _context.Remove(l);

            l = GetLeaseByPropertyIdAndTenantId(propertyId, tenantId);

            if (l == null)
                return true;

            return false;
        }

        public Lease GetLeaseByPropertyIdAndTenantId(int propertyId, int tenantId)
        {
            return _context.SingleOrDefault(l => l.PropertyId == propertyId && l.TenantId == tenantId);
        }

        public Lease UpdateLease(Lease updatedLease)
        {
            Lease l = GetLeaseByPropertyIdAndTenantId(updatedLease.PropertyId, updatedLease.TenantId);
            _context.Remove(l);
            _context.Add(updatedLease);

            return updatedLease;
        }
    }
}
