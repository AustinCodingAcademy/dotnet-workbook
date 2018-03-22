using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCorePaymentServices : IPaymentServices
    {
        private readonly EZRentDbContext _dbContext;

        public EFCorePaymentServices(EZRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Payment GetSinglePaymentById(int id) => _dbContext.Payments.Find(id);

        public List<Payment> GetPaymentsByPropertyID(int propertyId)
            => _dbContext.Payments
            .Where(p => p.PropertyId == propertyId)
            .ToList();


        public Payment CreatePayment(Payment newPayment)
        {
            _dbContext.Payments.Add(newPayment);
            _dbContext.SaveChanges();

            return newPayment;
        }

        public Payment UpdatePayment(Payment updatedPayment)
        {
            var payment = _dbContext.Payments.Update(updatedPayment);
            _dbContext.SaveChanges();

            return payment.Entity;
        }

        public bool DeletePayment(int id)
        {
            var payment = _dbContext.Payments.Find(id);

            _dbContext.Payments.Remove(payment);
            _dbContext.SaveChanges();

            if(_dbContext.Payments.Find(id) == null)
            {
                return true;
            }

            return false;
        }
    }
}
