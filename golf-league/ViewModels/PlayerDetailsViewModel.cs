using golf_league.Models;

namespace golf_league.ViewModels
{
    public class PlayerDetailsViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? StartIndex { get; set; }
        public decimal? CurrIndex { get; set; }
        public PlayerType PlayerType { get; set; }
        public int PlayerTypeId { get; set; }
        public bool Active { get; set; }
    }
}
