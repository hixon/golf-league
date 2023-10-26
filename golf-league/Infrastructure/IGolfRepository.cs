using golf_league.ViewModels;

namespace golf_league.Infrastructure
{
    public interface IGolfRepository
    {
        public CourseAdminViewModel GetCourses();
        public void SaveCourse(CourseDetailsViewModel info);
    }
}
