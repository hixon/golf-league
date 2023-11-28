namespace golf_league.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? LastUpdateDt { get; set; }
    }
}
