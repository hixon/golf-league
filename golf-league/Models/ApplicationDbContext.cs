using Microsoft.EntityFrameworkCore;

namespace golf_league.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Course> Course { get; set; }
        public DbSet<Tee> Tee { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<PlayerType> PlayerType { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }

}
