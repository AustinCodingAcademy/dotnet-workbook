using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockPaymentServices : IPaymentServices
    {
        List<Payment> _context;

        public MockPaymentServices()
        {
            _context = MockPayment.list;
        }

        public Payment CreatePayment(Payment newPayment)
        {
            int largestId = _context.OrderByDescending(p => p.Id).SingleOrDefault().Id;

            newPayment.Id = largestId + 1;
            _context.Add(newPayment);
            return newPayment;
        }

        public bool DeletePayment(int id)
        {
            Payment p = GetPaymentById(id);
            _context.Remove(p);

            p = GetPaymentById(id);
            if (p == null)
                return true;

            return false;
              
        }

        public Payment GetPaymentById(int id)
        {
            return _context.SingleOrDefault(p => p.Id == id);
        }

        public List<Payment> GetPaymentByPropertyId(int propertyId)
        {
            return _context.Where(p => p.PropertyId == propertyId).ToList();
        }

        public Payment UpdatePayment(Payment updatedPayment)
        {
            Payment p = GetPaymentById(updatedPayment.Id);
            _context.Remove(p);
            _context.Add(updatedPayment);
            return updatedPayment;
        }
    }
}
