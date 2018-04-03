using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCoreMaintenanceStatusServices : IMaintenanceStatusServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCoreMaintenanceStatusServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MaintenanceStatus GetMaintenanceStatus(int id)
            => _dbContext.MaintenanceStatuses.Find(id);
    }
}
