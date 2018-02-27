using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
{
    public class MockPropertyTypeServices : IPropertyTypeServices
    {
        private List<PropertyType> _context;

        public MockPropertyTypeServices()
        {
            _context = MockPropertyType.list;
        }

        public List<PropertyType> GetAllPropertyTypes()
        {
            return _context;
        }

        public PropertyType GetSinglePropertyTypeById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }
    }
}
