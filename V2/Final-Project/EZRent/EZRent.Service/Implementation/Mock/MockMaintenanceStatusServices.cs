using EZRent.Service.Interface;
using EZRent.Data.Mock;
using EZRent.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
{
    public class MockMaintenanceStatusServices : IMaintenanceStatusServices
    {
        private List<MaintenanceStatus> _context;

        public MockMaintenanceStatusServices()
        {
            _context = MockMaintenanceStatus.list;
        }

        public List<MaintenanceStatus> GetAllMaintenanceStatuses()
        {
            return _context;
        }

        public MaintenanceStatus GetSingleMaintenanceStatusById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }
    }
}
