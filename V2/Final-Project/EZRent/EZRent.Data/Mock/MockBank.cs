using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;

namespace EZRent.Data.Mock
{
    public static class MockBank
    {
        public static List<Bank> list = new List<Bank>()
            {
                new Bank {Id=1, AccountNumber = 11111111, RoutingNumber = 01010101, BankName ="Chase", UserId = 1},
                new Bank {Id=2, AccountNumber = 22222222, RoutingNumber = 23232323, BankName ="Frost", UserId = 2},
                new Bank {Id=3, AccountNumber = 33333333, RoutingNumber = 45454545, BankName ="Capital One", UserId = 3}
            };

            
    }
}
