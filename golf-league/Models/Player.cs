namespace golf_league.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? StartIndex { get; set; }
        public decimal? CurrIndex { get; set; }
        public PlayerType PlayerType { get; set; }
        public long PlayerTypeId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? LastUpdateDt { get; set; }
    }
}
