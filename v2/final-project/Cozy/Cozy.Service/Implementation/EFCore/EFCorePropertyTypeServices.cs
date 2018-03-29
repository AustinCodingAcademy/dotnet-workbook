using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCorePropertyTypeServices : IPropertyTypeServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCorePropertyTypeServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PropertyType GetSinglePropertyById(int id) => _dbContext.PropertyTypes.Find(id);
    }
}
