using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCorePaymentStatusServices : IPaymentStatusServices
    {
        private readonly EZRentDbContext _dbContext;

        public EFCorePaymentStatusServices(EZRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PaymentStatus GetPaymentStatusById(int id) => _dbContext.PaymentStatuses.Find(id);
    }
}
