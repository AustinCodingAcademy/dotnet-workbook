using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Interface
{
    public interface IPaymentStatusServices
    {
        PaymentStatus GetPaymentStatusById(int id);
    }
}
