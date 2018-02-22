using Cozy.Domain.Models;
using System;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockPayment
    {
        public static List<Payment> list = new List<Payment>
        {
            new Payment {Id=1, Amount=350, BankId=1, Posted = DateTime.Now, PropertyId=1, StatusId=2},
            new Payment {Id=2, Amount=350, BankId=1, Posted = DateTime.Now.AddMonths(-1), PropertyId=1, StatusId=1},
            new Payment {Id=3, Amount=350, BankId=1, Posted = DateTime.Now.AddMonths(-2), PropertyId=1, StatusId=1},
        };
    }
}
