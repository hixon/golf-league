namespace golf_league.ViewModels
{
    public class PlayerScoreDetailsViewModel
    {
        public Guid PlayerId { get; set; }
        public string DatePlayed { get; set; }
        public Guid CourseId { get; set; }
        public Guid TeeId { get; set; }
        public decimal Index { get; set; }
        public decimal Differential { get; set; }
        public int Total { get; set; }
        public IEnumerable<HoleDetailViewModel> Holes { get; set; }
    }
}
