using System.ComponentModel.DataAnnotations;

namespace Cozy.Domain.Models
{
    public class Bank
    {   
        // Properties
        public int Id { get; set;  }
        public string Name { get; set; }

        [Required, MinLength(10), MaxLength(10)]
        public int Account { get; set; }

        public int RoutingNumber { get; set; }
        public string UserId { get; set; } // Tenant
    }
}
