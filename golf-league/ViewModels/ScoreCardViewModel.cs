using golf_league.Models;

namespace golf_league.ViewModels
{
    //this is input to our score card view
    //we need all courses to select one from a drop down
    //all linking tees to the given course
    //all (active) players for the given league
    public class ScoreCardViewModel
    {
        public Course Course { get; set; }
        public IEnumerable<Tee> Tees { get; set; }
        public IEnumerable<HoleInfo> Holes { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
