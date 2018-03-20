using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Bank
    {
        public int Id { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        public int AccountNumber { get; set; }

        [Required]
        public int RoutingNumber { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
