using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
{
    public class MockPaymentStatusServices : 
        IPaymentStatusServices
    {
        private List<PaymentStatus> _context;

        public MockPaymentStatusServices()
        {
            _context = MockPaymentStatus.list;
        }

        public List<PaymentStatus> GetAllPaymentStatuses()
        {
            return _context;
        }

        public PaymentStatus GetPaymentStatusById(int id)
        {
            throw new NotImplementedException();
        }

        public PaymentStatus GetSinglePaymentStatusById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }
    }
}
