using DatabaseExample.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseExample.Data
{
    public class CharacterContext : DbContext
    {
        public CharacterContext()
        {
        }

        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        {}

        public DbSet<Character> Characters { get; set; }
    }
}