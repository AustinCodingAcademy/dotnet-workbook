using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
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
            Lease toBeDeletedLease = GetLeaseByPropertyAndTenantId(propertyId, tenantId);
            _context.Remove(toBeDeletedLease);

            toBeDeletedLease = GetLeaseByPropertyAndTenantId(propertyId, tenantId);
            if (toBeDeletedLease == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Lease GetLeaseByPropertyAndTenantId(int propertyId, int tenantId)
        {
            return _context.SingleOrDefault(l => l.PropertyId == propertyId && l.TenantId == tenantId);
        }

        public List<Lease> GetAllLeases()
        {
            return _context;
        }

        public Lease GetLeaseByProperty(int propertyId)
        {
            return _context.SingleOrDefault(a => a.PropertyId == propertyId);
        }

    
        public Lease GetLeaseByTenantId(int tenantId)
        {
            return _context.Where(b => b.End >= DateTime.Now).SingleOrDefault(g => g.TenantId == tenantId);
        }


        public Lease UpdateLease(Lease updatedLease)
        {
            Lease oldLease = GetLeaseByProperty(updatedLease.PropertyId);

            _context.Remove(oldLease);
            _context.Add(updatedLease);

            return updatedLease;
        }

    }
}
