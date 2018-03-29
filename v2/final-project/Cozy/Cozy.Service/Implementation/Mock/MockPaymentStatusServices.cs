using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockPaymentStatusServices : IPaymentStatusServices
    {
        private List<PaymentStatus> _context;

        public MockPaymentStatusServices()
        {
            _context = MockPaymentStatus.list;
        }
        public PaymentStatus GetPaymentStatusById(int id)
        {
            return _context.SingleOrDefault(p => p.Id == id);
        }
    }
}
