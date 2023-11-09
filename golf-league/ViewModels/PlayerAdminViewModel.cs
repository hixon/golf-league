using golf_league.Models;

namespace golf_league.ViewModels
{
    public class PlayerAdminViewModel
    {
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<PlayerType> PlayerTypes { get; set; }
        public PlayerDetailsViewModel Details { get; set; }
    }
}
