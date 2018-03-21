using Cozy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Data.Database
{
    public class CozyDbContext : DbContext
    {
        // No AppUser, Landlord, or tenant

        public DbSet<Bank> Banks { get; set; }

        //Lease

    }
}
