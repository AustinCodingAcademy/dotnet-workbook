using System.Collections.Generic;
using Cozy.Domain.Models;

namespace Cozy.Data.Mock
{
    public static class MockLeaseType
    {
        public static List<LeaseType> list = new List<LeaseType>
        {
            new LeaseType {Id=1, Description = "Month-to-month"},
            new LeaseType {Id=1, Description = "Fixed term"},
        };
    }
}
