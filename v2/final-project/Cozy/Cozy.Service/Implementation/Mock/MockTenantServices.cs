using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockTenantServices : ITenantServices
    {
        private List<Tenant> _context;

        public MockTenantServices()
        {
            _context = MockTenant.list;
        }

        public Tenant GetTenantById(int id)
        {
            return _context.SingleOrDefault(t => t.Id == id);
        }

        public Tenant GetTenantById(string id)
        {
            throw new System.NotImplementedException();
        }

        object ITenantServices.GetTenantById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
