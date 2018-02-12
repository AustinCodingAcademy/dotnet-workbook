using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CableProvider.Domain.Models;

namespace CableProvider.Data
{
    public class CableProviderDbContext : DbContext
    {
        public CableProviderDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Location> Locations { get; set; }


    }
}
