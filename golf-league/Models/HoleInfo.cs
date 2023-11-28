namespace golf_league.Models
{
    public class HoleInfo
    {
        public Guid Id { get; set; }
        public Guid TeeId { get; set; }
        public int Number { get; set; }
        public int Length { get; set; }
        public int Par { get; set; }
        public int Hcp9 { get; set; }
        public int Hcp18 { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime LastUpdateDt { get; set; }
    }
}
