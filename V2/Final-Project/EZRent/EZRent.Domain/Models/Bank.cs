using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public int AccountNumber { get; set; }
        public int RoutingNumber { get; set; }
        public int UserId { get; set; }
    }
}
