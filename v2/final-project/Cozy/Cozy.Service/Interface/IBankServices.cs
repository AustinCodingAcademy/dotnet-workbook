using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Service.Interface
{
    public interface IBankServices
    {
        // Read
        Bank GetSingleBankById(int id);
        List<Bank> GetBanksByTenantId(string id);

        // Create
        Bank CreateBank(Bank newBank);

        // Update
        Bank UpdateBank(Bank updatedBank);

        // Delete
        bool DeleteBank(int id);
        List<Bank> GetBanksByTenantId(int id);
    }
}
