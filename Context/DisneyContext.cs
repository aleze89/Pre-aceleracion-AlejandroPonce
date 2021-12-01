using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisney.Context
{
    public class DisneyContext : DbContext
    {
        public DbSet<Models.Character> Characters { get; set; }
        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Models.Genre> Genres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UJVMHBA\MSQLSERVER;Database=DisneyDB;Trusted_Connection=True;");
        }

    }
}
