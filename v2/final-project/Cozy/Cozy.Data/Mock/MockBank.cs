using System.Collections.Generic;
using Cozy.Domain.Models;

namespace Cozy.Data.Mock
{
    public static class MockBank
    {
        public static List<Bank> list = new List<Bank>()
        {
            new Bank {Id=1, Account=123456, RoutingNumber=123456, Name="Ally Bank", UserId = 1},
            new Bank {Id=2, Account=847582, RoutingNumber=646372, Name="Bank of America", UserId = 1},
            new Bank {Id=3, Account=102933, RoutingNumber=646372, Name="Wells Fargo", UserId = 2},
        };
    }
}
