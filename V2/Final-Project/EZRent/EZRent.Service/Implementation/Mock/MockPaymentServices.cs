using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EZRent.Service.Implementation.Mock
{
    public class MockPaymentServices :IPaymentServices
    {
        private List<Payment> _context;

        public MockPaymentServices()
        {
            _context = MockPayment.list;
        }

        public Payment CreatePayment(Payment newPayment)
        {
            int largestId = _context.OrderByDescending(b => b.Id).FirstOrDefault().Id;

            newPayment.Id = largestId + 1;
            _context.Add(newPayment);

            return newPayment;
        }

        public bool DeletePayment(int id)
        {
            Payment toBeDeletedPayment = GetSinglePaymentById(id);
            _context.Remove(toBeDeletedPayment);

            toBeDeletedPayment = GetSinglePaymentById(id);
            if (toBeDeletedPayment == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Payment> GetAllPayments()
        {
            return _context;
        }

        public Payment GetSinglePaymentById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }

        public Payment UpdatePayment(Payment updatedPayment)
        {
            Payment oldPayment = GetSinglePaymentById(updatedPayment.Id);

            _context.Remove(oldPayment);
            _context.Add(updatedPayment);

            return updatedPayment;
        }
    }
