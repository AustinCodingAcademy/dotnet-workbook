using System;

namespace Cozy.Domain.Models
{
    public class Payment
    {
        // properties
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Posted { get; set; }
        public int StatusId { get; set; }
        public int BankId { get; set; }
        public int PropertyId { get; set; }

        // navigation
        public PaymentStatus Status { get; set; }
        public Bank Bank { get; set; }
        public Property Property { get;set;}
    }
}
