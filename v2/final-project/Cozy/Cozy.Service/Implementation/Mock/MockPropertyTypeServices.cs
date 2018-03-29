using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockPropertyTypeServices : IPropertyTypeServices
    {
        private List<PropertyType> _context;

        public MockPropertyTypeServices()
        {
            _context = MockPropertyType.list;
        }
        public PropertyType GetSinglePropertyById(int id)
        {
            return _context.SingleOrDefault(p => p.Id == id);
        }
    }
}
