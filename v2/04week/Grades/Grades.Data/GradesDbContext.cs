using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Grades.Data
{
    public class GradesDbContext : DbContext
    {
        public SchooolDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Session> Sessions {get; set;} 
        public DbSet<Student> Students { get; set; }
    }
}
