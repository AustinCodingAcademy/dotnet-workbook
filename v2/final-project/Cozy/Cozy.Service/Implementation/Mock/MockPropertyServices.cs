using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockPropertyServices : IPropertyServices
    {
        List<Property> _context;

        public MockPropertyServices()
        {
            _context = MockProperty.list;
        }

        public Property CreateProperty(Property newProperty)
        {
            int largestId = _context.OrderByDescending(p => p.Id).FirstOrDefault().Id;

            newProperty.Id = largestId + 1;
            _context.Add(newProperty);

            return newProperty;
        }

        public bool DeleteProperty(int id)
        {
            Property p = GetSinglePropertyById(id);
            _context.Remove(p);

            p = GetSinglePropertyById(id);
            if (p == null)
                return true;

            return false;
        }

        public List<Property> GetAllPropertiesByLandlordId(int userId)
        {
            return _context.Where(p => p.LandlordId == userId).ToList();
        }

        public Property GetSinglePropertyById(int id)
        {
            return _context.SingleOrDefault(p => p.Id == id);
        }

        public Property UpdateProperty(Property updatedPorperty)
        {
            Property p = GetSinglePropertyById(updatedPorperty.Id);

            _context.Remove(p);
            _context.Add(updatedPorperty);

            return updatedPorperty;

        }
    }
}
