using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCorePropertyTypeServices : IPropertyTypeServices
    {
        private readonly EZRentDbContext _dbContext;

        public EFCorePropertyTypeServices(EZRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PropertyType> GetPropertyTypes() => _dbContext.PropertyTypes.ToList();
    }
}
