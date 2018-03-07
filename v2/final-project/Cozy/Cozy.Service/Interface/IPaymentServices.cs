using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Service.Interface
{
    public interface IPaymentServices
    {
        Payment GetPaymentById(int id);
        List<Payment> GetPaymentByPropertyId(int propertyId);
        Payment CreatePayment(Payment newPayment);
        Payment UpdatePayment(Payment updatedPayment);
        bool DeletePayment(int id);
    }
}
