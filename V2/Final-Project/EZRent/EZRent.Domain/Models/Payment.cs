using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int BankId { get; set; }
        public int PropertyId { get; set; }
        public DateTime DatePosted { get; set; }
        public int StatusId { get; set; }

        //Navigation
        public PaymentStatus Status { get; set; }
        public Bank Bank { get; set; }
        public Property Property { get; set; }

    }
}
