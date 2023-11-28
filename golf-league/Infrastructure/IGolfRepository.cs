using golf_league.Models;
using golf_league.ViewModels;

namespace golf_league.Infrastructure
{
    public interface IGolfRepository
    {
        public CourseAdminViewModel GetCourses();
        public PlayerAdminViewModel GetPlayers();
        public IEnumerable<Player> GetAllPlayers();
        public ScoreCardViewModel GetScoreCardDetails(Guid courseId);
        public IEnumerable<Course> GetAllCourses();
        public Course GetCourseById(Guid courseId);
        public IEnumerable<Tee> GetTeesByCourseId(Guid courseId);
        public IEnumerable<HoleInfo> GetHoleInfoByCourseId(Guid courseId);

        public void SaveCourse(CourseDetailsViewModel info);
        public void SavePlayer(PlayerDetailsViewModel info);
    }
}
