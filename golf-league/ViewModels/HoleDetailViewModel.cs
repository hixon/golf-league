namespace golf_league.ViewModels
{
    public class HoleDetailViewModel
    {
         public Guid HoleId { get; set; }
         public int Number { get; set; }
         public int Par { get; set; }
         public int Score { get; set; }
         public int Hcp9 { get; set; }
         public int Hcp18 { get; set; }
    }
}
