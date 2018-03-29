using Microsoft.AspNetCore.Identity;

namespace Cozy.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
