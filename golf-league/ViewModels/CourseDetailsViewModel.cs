namespace golf_league.ViewModels
{
    public class CourseDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Tee { get; set; }
        public int Slope { get; set; }
        public decimal Rating { get; set; }
        public bool Active { get; set; }
    }
}
