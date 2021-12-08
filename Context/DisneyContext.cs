using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisney.Context
{
    public class DisneyContext : DbContext
    {
        public DbSet<Entities.Character> Characters { get; set; }
        public DbSet<Entities.Movie> Movies { get; set; }
        public DbSet<Entities.Genre> Genres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UJVMHBA\MSQLSERVER;Database=DisneyDB;Trusted_Connection=True");
        }

    }
}
