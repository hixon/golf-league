using golf_league.Models;

namespace golf_league.ViewModels
{
    public class CourseDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public string Tees { get; set; }
    }
}
