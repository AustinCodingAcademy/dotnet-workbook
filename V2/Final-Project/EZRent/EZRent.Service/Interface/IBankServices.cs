using EZRent.Domain.Models;
using System.Collections.Generic;

namespace EZRent.Service.Interface
{
    public interface IBankServices
    {
        // Read
        List<Bank> GetAllBanks();
        Bank GetSingleBankById(int id);
        Bank GetSingleBankByUserId(int id);

        // Create
        Bank CreateBank(Bank newBank);

        // Update
        Bank UpdateBank(Bank updatedBank);
        // Delete
        bool DeleteBank(int id);
    }
}
