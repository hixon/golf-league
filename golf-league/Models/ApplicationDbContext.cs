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
        public DbSet<HoleInfo> HoleInfo { get; set; }
        public DbSet<HoleScore> HoleScore { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<LeaguePlayer> LeaguePlayer { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<ScoreDetail> ScoreDetail { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }

}
