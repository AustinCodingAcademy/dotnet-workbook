using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
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
            int largestId = _context.OrderByDescending(b => b.Id).FirstOrDefault().Id;

            newMaintenance.Id = largestId + 1;
            _context.Add(newMaintenance);

            return newMaintenance;
        }

        public bool DeleteMaintenance(int id)
        {
            Maintenance toBeDeletedMaintenance = GetSingleMaintenanceById(id);
            _context.Remove(toBeDeletedMaintenance);

            toBeDeletedMaintenance = GetSingleMaintenanceById(id);
            if (toBeDeletedMaintenance == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Maintenance> GetAllMaintenances()
        {
            return _context;
        }

        public Maintenance GetSingleMaintenanceById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }

        public Maintenance UpdateMaintenance(Maintenance updatedMaintenance)
        {
            Maintenance oldMaintenance = GetSingleMaintenanceById(updatedMaintenance.Id);

            _context.Remove(oldMaintenance);
            _context.Add(updatedMaintenance);

            return updatedMaintenance;
        }
    }
}
