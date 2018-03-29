using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockMainternanceStatusServices : IMaintenanceStatusServices
    {
        private List<MaintenanceStatus> _context;

        public MockMainternanceStatusServices()
        {
            _context = MockMaintenanceStatus.list;
        }
        public MaintenanceStatus GetMaintenanceStatus(int id)
        {
            return _context.SingleOrDefault(m => m.Id == id);
        }
    }
}
