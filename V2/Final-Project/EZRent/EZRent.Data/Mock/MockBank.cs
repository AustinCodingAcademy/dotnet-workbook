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
                new Bank {Id=1, AccountNumber = 22223444, RoutingNumber = 45354343, BankName ="Bank Z"},
                new Bank {Id=2, AccountNumber = 22224444, RoutingNumber = 45354343, BankName ="Bank X"},
                new Bank {Id=3, AccountNumber = 22222444, RoutingNumber = 45354343, BankName ="Bank Y"}
            };

            
    }
}
