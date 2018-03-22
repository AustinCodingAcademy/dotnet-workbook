using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCoreLeaseTypeServices : ILeaseTypeServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCoreLeaseTypeServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public LeaseType GetLeaseType(int id) => _dbContext.LeaseTypes.Find(id);
    }
}
