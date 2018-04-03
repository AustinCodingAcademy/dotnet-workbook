using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
{
    public class MockTenantServices : ITenantServices
    {
        private List<Tenant> _context;

        public MockTenantServices()
        {
            _context = MockTenant.list;
        }

        public Tenant CreateTenant(Tenant newTenant)
        {
           
            _context.Add(newTenant);

            return newTenant;
        }

        public bool DeleteTenant(string id)
        {
            Tenant toBeDeletedTenant = GetSingleTenantById(id);
            _context.Remove(toBeDeletedTenant);

            toBeDeletedTenant = GetSingleTenantById(id);
            if (toBeDeletedTenant == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tenant> GetAllTenants()
        {
            return _context;
        }

        public Tenant GetSingleTenantById(string id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }

        public Tenant UpdateTenant(Tenant updatedTenant)
        {
            Tenant oldTenant = GetSingleTenantById(updatedTenant.Id);

            _context.Remove(oldTenant);
            _context.Add(updatedTenant);

            return updatedTenant;
        }
    }
}
