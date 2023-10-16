namespace golf_league.Models
{
    public class LeaguePlayer
    {
        public Guid Id { get; set; }
        public Guid LeagueId { get; set; }
        public Guid PlayerId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? LastUpdateDt { get; set; }
    }
}
