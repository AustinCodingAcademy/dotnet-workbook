using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IPaymentServices
    {
        Payment GetSinglePaymentById(int id);
        List<Payment> GetPaymentsByPropertyID(int propertyId);

        // Create
        Payment CreatePayment(Payment newPayment);

        // Update
        Payment UpdatePayment(Payment updatedPayment);
        // Delete
        bool DeletePayment(int id);
    }
}
