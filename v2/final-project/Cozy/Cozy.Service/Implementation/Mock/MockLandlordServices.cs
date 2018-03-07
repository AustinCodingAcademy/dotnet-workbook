using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockLandlordServices : ILandlordServices
    {
        private List<Landlord> _context;

        public MockLandlordServices()
        {
            _context = MockLandlord.list;
        }

        public Landlord GetSingleLandlordById(int id)
        {
            return _context.SingleOrDefault(l => l.Id == id);
        }
    }
}
