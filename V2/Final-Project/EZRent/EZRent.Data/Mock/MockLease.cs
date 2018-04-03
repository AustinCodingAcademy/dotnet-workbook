using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;


namespace EZRent.Data.Mock
{
    public static class MockLease
    {
        public static List<Lease> list = new List<Lease>()
            {
                new Lease {Start = new DateTime(2017, 07, 04), End= new DateTime(2018,07,04), LeaseTypeId=1, PropertyId=1, TenantId="1"},
                new Lease {Start = new DateTime(2017, 07, 05), End= new DateTime(2018,07,05), LeaseTypeId=2, PropertyId=2, TenantId="2"},
                new Lease {Start = new DateTime(2017, 07, 06), End= new DateTime(2018,07,06), LeaseTypeId=1, PropertyId=3, TenantId="3"},
            };
        }
    }