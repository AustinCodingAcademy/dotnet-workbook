using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;

namespace EZRent.Data.Mock
{
    public static class MockLeaseType
    {
        public static List<LeaseType> list = new List<LeaseType>()
            {
                new LeaseType {Id=1, Description="Month-to-Month"},
                new LeaseType {Id=1, Description="Fixed"}
            };
        }
    }
