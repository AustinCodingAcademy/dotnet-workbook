using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCorePaymentStatusServices : IPaymentStatusServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCorePaymentStatusServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public PaymentStatus GetPaymentStatusById(int id) => _dbContext.PaymentStatuses.Find(id);
    }
}
