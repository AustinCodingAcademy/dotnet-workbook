using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EZRent.Service.Implementation.Mock
{
    public class MockPropertyServices : IPropertyServices
    {
        private List<Property> _context;

        public MockPropertyServices()
        {
            _context = MockProperty.list;
        }

        public Property CreateProperty(Property newProperty)
        {
            int largestId = _context.OrderByDescending(b => b.Id).FirstOrDefault().Id;

            newProperty.Id = largestId + 1;
            _context.Add(newProperty);

            return newProperty;
        }

        public bool DeleteProperty(int id)
        {
            Property toBeDeletedProperty = GetSinglePropertyById(id);
            _context.Remove(toBeDeletedProperty);

            toBeDeletedProperty = GetSinglePropertyById(id);
            if (toBeDeletedProperty == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Property> GetAllPropertys()
        {
            return _context;
        }

        public Property GetSinglePropertyById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }

        public Property UpdateProperty(Property updatedProperty)
        {
            Property oldProperty = GetSinglePropertyById(updatedProperty.Id);

            _context.Remove(oldProperty);
            _context.Add(updatedProperty);

            return updatedProperty;
        }
    }
}
