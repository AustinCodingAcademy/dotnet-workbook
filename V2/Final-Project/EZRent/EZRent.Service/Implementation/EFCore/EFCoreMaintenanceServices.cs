using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCoreMaintenanceServices : IMaintenanceServices
    {
        private readonly EZRentDbContext _dbContext;

        public EFCoreMaintenanceServices(EZRentDbContext dbContext)
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

            if(_dbContext.Maintenances.Find(id) == null)
            {
                return true;
            }

            return false;
        }

        public List<Maintenance> GetMaintenanceByPropertyId(int propertyId)
            => _dbContext.Maintenances.Where(m => m.PropertyId == propertyId).ToList();

        public Maintenance GetSingleMaintenanceById(int id) => _dbContext.Maintenances.Find(id);

        public Maintenance UpdateMaintenance(Maintenance updatedMaintenance)
        {
            var maintenance = _dbContext.Maintenances.Update(updatedMaintenance);
            _dbContext.SaveChanges();

            return maintenance.Entity;

        }
    }
}
