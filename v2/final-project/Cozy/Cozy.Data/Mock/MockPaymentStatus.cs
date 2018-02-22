using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Data.Mock
{
    public class MockPaymentStatus
    {
        public List<Domain.Models.PaymentStatus> list;

        public MockPaymentStatus()
        {
            list = new List<Domain.Models.PaymentStatus>
            {
                new Domain.Models.PaymentStatus { Id = 1, Description = "Paid"},
                new Domain.Models.PaymentStatus { Id = 2, Description = "Processing"},
                new Domain.Models.PaymentStatus { Id = 3, Description = "Due"},
                new Domain.Models.PaymentStatus { Id = 4, Description = "Overdue"},
            };
        }
    }
}
