using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCorePropertyServices : IPropertyServices
    {
        private readonly EZRentDbContext _dbContext;

        public EFCorePropertyServices(EZRentDbContext dbContext)
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

            if(_dbContext.Properties.Find(id) == null)
            {
                return true;
            }
            return false;
        }

        public List<Property> GetPropertiesByLandlordId(string userId)
            => _dbContext.Properties
            .Where(p => p.LandlordId == userId)
            .ToList();

        public Property GetPropertyByTenantId(string id)
            => _dbContext.Properties.SingleOrDefault(p => p.CurrentTenantId == id);

        public Property GetSinglePropertyById(int id) => _dbContext.Properties.Find(id);

        public Property UpdateProperty(Property updatedProperty)
        {
            var property = _dbContext.Properties.Update(updatedProperty);
            _dbContext.SaveChanges();

            return property.Entity;

        }
    }
}
