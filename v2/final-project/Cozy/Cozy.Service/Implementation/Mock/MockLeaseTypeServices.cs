using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockLeaseTypeServices : ILeaseTypeServices
    {
        List<LeaseType> _context;

        public MockLeaseTypeServices()
        {
            _context = MockLeaseType.list;
        }

        public LeaseType GetLeaseType(int id)
        {
            return _context.SingleOrDefault(lt => lt.Id == id);
        }
    }
}
