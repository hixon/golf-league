namespace golf_league.Models
{
    public class Score
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public DateTime DatePlayed { get; set; }
        public decimal Index { get; set; } //used to calculate a course handicap to show net details
        public int Total { get; set; }
        public decimal Differential { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? LastUpdateDt { get; set; }
    }
}
