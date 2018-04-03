using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Tenant
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MonthlyIncome { get; set; }
        public string About { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfPets { get; set; }
    }
}
