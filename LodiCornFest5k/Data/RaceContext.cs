using LodiCornFest5k.Models;
using Microsoft.EntityFrameworkCore;

namespace LodiCornFest5k.Data
{
    public class RaceContext : DbContext
    {
        public RaceContext(DbContextOptions<RaceContext> options)
            : base(options)
        {
        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Runner> Runners { get; set; }
        public DbSet<RaceRunner> RaceRunners { get; set; }
        public DbSet<AgeGroup> AgeGroups { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
