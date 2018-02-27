using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IPaymentStatusServices
    {
        List<PaymentStatus> GetAllPaymentStatuses();
        PaymentStatus GetSinglePaymentStatusById(int id);

    }
}
