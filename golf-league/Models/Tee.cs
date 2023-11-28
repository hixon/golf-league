namespace golf_league.Models
{
    public class Tee
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public string Name { get; set; }
        public int Slope { get; set; }
        public decimal Rating { get; set; }
        public int Par { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime LastUpdateDt { get; set; }
    }
}
