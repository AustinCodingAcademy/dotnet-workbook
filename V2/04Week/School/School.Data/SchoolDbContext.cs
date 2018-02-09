using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using School.Domain.Models;

namespace School.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Session> Sessions { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
