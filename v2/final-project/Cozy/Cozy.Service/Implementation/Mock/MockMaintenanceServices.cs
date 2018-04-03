using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockMaintenanceServices : IMaintenanceServices
    {
        private List<Maintenance> _context;

        public MockMaintenanceServices()
        {
            _context = MockMaintenance.list;
        }

        public Maintenance CreateMaintenance(Maintenance newMaintenance)
        {
            int largestId = _context.OrderByDescending(m => m.Id).SingleOrDefault().Id;
            newMaintenance.Id = largestId + 1;
            _context.Add(newMaintenance);
            return newMaintenance;
        }

        public bool DeleteMaintenance(int id)
        {
            Maintenance m = GetMaintenanceById(id);
            _context.Remove(m);

            m = GetMaintenanceById(id);
            if (m == null)
                return true;

            return false;
        }

        public Maintenance GetMaintenanceById(int id)
        {
            return _context.SingleOrDefault(m => m.Id == id);
        }

        public List<Maintenance> GetMaintenancesByPropertyId(int propertyId)
        {
            return _context.Where(m => m.PropertyId == propertyId).ToList();
        }

        public Maintenance UpdateMaintenance(Maintenance updatedMaintenance)
        {
            Maintenance m = GetMaintenanceById(updatedMaintenance.Id);
            _context.Remove(m);
            _context.Add(updatedMaintenance);

            return updatedMaintenance;
        }
    }
}
