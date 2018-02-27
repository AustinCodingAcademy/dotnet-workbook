using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;

namespace EZRent.Data.Mock
{
    public static class MockPaymentStatus
    {
        public static List<PaymentStatus> list = new List<PaymentStatus>()
            {
                new PaymentStatus {Id=1, Description= "Paid" },
                new PaymentStatus {Id=2, Description= "Processing" },
                new PaymentStatus {Id=3, Description= "Due" },
                new PaymentStatus {Id=4, Description= "Overdue" },
            };
    }
}
