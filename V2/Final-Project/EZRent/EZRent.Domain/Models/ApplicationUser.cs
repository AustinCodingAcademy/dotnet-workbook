using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
