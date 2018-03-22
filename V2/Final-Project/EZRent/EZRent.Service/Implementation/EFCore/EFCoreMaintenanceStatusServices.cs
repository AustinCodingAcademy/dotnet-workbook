using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCoreMaintenanceStatusServices : IMaintenanceStatusServices
    {
        private readonly EZRentDbContext _dbContext;

        public EFCoreMaintenanceStatusServices(EZRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MaintenanceStatus GetMaintenanceStatus(int id)
            => _dbContext.MaintenanceStatuses.Find(id);
    }
}
