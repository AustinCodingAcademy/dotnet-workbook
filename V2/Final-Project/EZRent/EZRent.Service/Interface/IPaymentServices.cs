using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IPaymentServices
    {
        List<Payment> GetAllPayments();
        Payment GetSinglePaymentById(int id);

        // Create
        Payment CreatePayment(Payment newPayment);

        // Update
        Payment UpdatePayment(Payment updatedPayment);
        // Delete
        bool DeletePayment(int id);
    }
}
