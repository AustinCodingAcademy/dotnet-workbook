using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCoreMaintenanceServices : IMaintenanceServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCoreMaintenanceServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Maintenance CreateMaintenance(Maintenance newMaintenance)
        {
            _dbContext.Maintenances.Add(newMaintenance);
            _dbContext.SaveChanges();

            return newMaintenance;
        }

        public bool DeleteMaintenance(int id)
        {
            var maintenance = _dbContext.Maintenances.Find(id);

            _dbContext.Maintenances.Remove(maintenance);
            _dbContext.SaveChanges();

            if (_dbContext.Maintenances.Find(id) == null)
            {
                return true;
            }

            return false;
        }

        public Maintenance GetMaintenanceById(int id) => _dbContext.Maintenances.Find(id);

        public List<Maintenance> GetMaintenancesByPropertyId(int propertyId)
            => _dbContext.Maintenances.Where(m => m.PropertyId == propertyId).ToList();

        public Maintenance UpdateMaintenance(Maintenance updatedMaintenance)
        {
            var maintenance = _dbContext.Maintenances.Update(updatedMaintenance);
            _dbContext.SaveChanges();

            return maintenance.Entity;
        }
    }
}
