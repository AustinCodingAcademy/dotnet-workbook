using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCorePaymentServices : IPaymentServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCorePaymentServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Payment CreatePayment(Payment newPayment)
        {
            _dbContext.Payments.Add(newPayment);
            _dbContext.SaveChanges();

            return newPayment;
        }

        public bool DeletePayment(int id)
        {
            var payment = _dbContext.Payments.Find(id);

            _dbContext.Payments.Remove(payment);
            _dbContext.SaveChanges();

            if (_dbContext.Payments.Find(id) == null)
            {
                return true;
            }

            return false;
        }

        public Payment GetPaymentById(int id) => _dbContext.Payments.Find(id);

        public List<Payment> GetPaymentsByPropertyId(int propertyId)
        {
            return _dbContext.Payments
                .Where(p => p.PropertyId == propertyId)
                .ToList();
        }

        public Payment UpdatePayment(Payment updatedPayment)
        {
            var payment = _dbContext.Payments.Update(updatedPayment);
            _dbContext.SaveChanges();

            return payment.Entity;
        }
    }
}
