using golf_league.Models;

namespace golf_league.ViewModels
{
    public class CourseAdminViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public string Tees { get; set; }
        public string AllCourses { get; set; }
        public CourseDetailsViewModel Details { get; set; }
    }
}
