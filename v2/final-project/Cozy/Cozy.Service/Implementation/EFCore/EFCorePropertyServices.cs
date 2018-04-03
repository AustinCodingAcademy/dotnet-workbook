using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCorePropertyServices : IPropertyServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCorePropertyServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Property CreateProperty(Property newProperty)
        {
            _dbContext.Properties.Add(newProperty);
            _dbContext.SaveChanges();

            return newProperty;
        }

        public bool DeleteProperty(int id)
        {
            var property = _dbContext.Properties.Find(id);
            _dbContext.Properties.Remove(property);
            _dbContext.SaveChanges();

            if (_dbContext.Properties.Find(id) == null)
            {
                return true;
            }

            return false;
        }

        public List<Property> GetAllPropertiesByLandlordId(string userId)
        {
            return _dbContext.Properties
                .Where(p => p.LandlordId == userId)
                .ToList();
        }

        public List<Property> GetAllPropertiesByLandlordId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Property GetPropertyByCurrentTenant(string id)
            => _dbContext.Properties.SingleOrDefault(p => p.CurrentTenantId == id);

        public Property GetSinglePropertyById(int id) => _dbContext.Properties.Find(id);

        public Property UpdateProperty(Property updatedPorperty)
        {
            var property = _dbContext.Properties.Update(updatedPorperty);
            _dbContext.SaveChanges();

            return property.Entity;
        }
    }
}
