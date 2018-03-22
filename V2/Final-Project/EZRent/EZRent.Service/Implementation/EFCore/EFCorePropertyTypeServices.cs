using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCorePropertyTypeServices : IPropertyTypeServices
    {
        private readonly EZRentDbContext _dbContext;

        public EFCorePropertyTypeServices(EZRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PropertyType GetSinglePropertyTypeById(int id) => _dbContext.PropertyTypes.Find(id);
    }
}
