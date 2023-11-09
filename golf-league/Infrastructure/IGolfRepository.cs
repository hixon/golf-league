using golf_league.ViewModels;

namespace golf_league.Infrastructure
{
    public interface IGolfRepository
    {
        public CourseAdminViewModel GetCourses();
        public PlayerAdminViewModel GetPlayers();
        public void SaveCourse(CourseDetailsViewModel info);
        public void SavePlayer(PlayerDetailsViewModel info);
    }
}
