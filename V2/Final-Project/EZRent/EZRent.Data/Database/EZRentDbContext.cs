using EZRent.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Data.Database
{
    public class EZRentDbContext : DbContext
    {
        // No AppUser, Landlord, or Tenant
        public DbSet<Bank> Banks {get; set;}
    }
}
