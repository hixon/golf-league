namespace golf_league.Models
{
    public class Score
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid PlayerId { get; set; }
        public long ScoreTypeId { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
        public decimal Differential { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? LastUpdateDt { get; set; }
    }
}
