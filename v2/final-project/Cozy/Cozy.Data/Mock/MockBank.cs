using System.Collections.Generic;
using Cozy.Domain.Models;

namespace Cozy.Data.Mock
{
    public static class MockBank
    {
        private static List<Bank> list = new List<Bank>()
        {
            new Bank {Id=1, Account=123456, RoutingNumber=123456, Name="Bank of America"},
            new Bank {Id=2, Account=847582, RoutingNumber=646372, Name="Wells Fargo"},
            new Bank {Id=3, Account=102933, RoutingNumber=634754, Name="Austin Telco"},
        };

        public static List<Bank> List { get; set; }
    }
}
