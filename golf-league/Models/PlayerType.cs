namespace golf_league.Models
{
    public class PlayerType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? LastUpdateDt { get; set; }
    }
}
