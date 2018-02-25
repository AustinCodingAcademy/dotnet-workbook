using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Service.Interface
{
    public interface IBankServices
    {
        // Read
        List<Bank> GetAllBanks();
        Bank GetSingleBankById(int id);
        Bank GetSingleBankByUserId(int userId);

        // Create
        Bank CreateBank(Bank newBank);

        // Update
        Bank UpdateBank(Bank updatedBank);

        // Delete
        bool DeleteBank(int id);

    }
}
