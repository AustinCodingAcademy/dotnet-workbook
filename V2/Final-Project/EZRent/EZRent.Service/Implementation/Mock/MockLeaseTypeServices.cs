using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EZRent.Service.Implementation.Mock
{
    public class MockLeaseTypeServices : ILeaseTypeServices
    {
        private List<LeaseType> _context;

        public MockLeaseTypeServices()
        {
            _context = MockLeaseType.list;
        }

        public List<LeaseType> GetAllLeaseTypes()
        {
            return _context;
        }

        public LeaseType GetSingleLeaseTypeById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }
    }
}
