using Cozy.Domain.Models;
using System;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockLease
    {
        public static List<Lease> list = new List<Lease>
        {
            new Lease { PropertyId =1, TenantId=1, LeaseTypeId=1, Start=DateTime.Now, End= DateTime.Now.AddMonths(7) },
            new Lease { PropertyId =2, TenantId=2, LeaseTypeId=2, Start=DateTime.Now.AddDays(-4), End= DateTime.Now.AddMonths(7) },
            new Lease { PropertyId =3, TenantId=4, LeaseTypeId=2, Start=DateTime.Now.AddMonths(-1), End= DateTime.Now.AddMonths(3) },
            new Lease { PropertyId =4, TenantId=3, LeaseTypeId=1, Start=DateTime.Now.AddMonths(-3), End= DateTime.Now.AddMonths(10) },
        };
    }
}
