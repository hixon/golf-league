using AutoMapper;
using golf_league.Models;
using golf_league.ViewModels;

namespace golf_league.Infrastructure
{
    public class GolfRepository: IGolfRepository
    {
        private IMapper _mapper { get; }
        private readonly IConfiguration _configuration;
        private ApplicationDbContext _context { get; set; }

        public GolfRepository(ApplicationDbContext _ctx, IMapper _map, IConfiguration _config)
        {
            _context = _ctx;
            _mapper = _map;
            _configuration = _config;
        }
        public CourseAdminViewModel GetCourses()
        {
            return new CourseAdminViewModel()
            {
                Courses = new List<Course>(),
            };
        }

        public void SaveCourse(CourseDetailsViewModel info)
        {
            //check to see if the course exists and add it if so
            //otherwise update the details if they changed
            if(info.Id == Guid.Empty)
            {
                //Save new Course
                SaveNewCourse(info);
            }
            else
            {
                //get course and save any changes
                Course courseToUpdate = _context.Course.Where(c => c.Id == info.Id).FirstOrDefault();

                if(courseToUpdate is null)
                {
                    SaveNewCourse(info);
                }
                else
                {
                    //replace w/ automapper call
                    courseToUpdate.Name = info.Name;
                    courseToUpdate.Tee = info.Tee;
                    courseToUpdate.Rating = info.Rating;
                    courseToUpdate.Slope = info.Slope;
                    courseToUpdate.Active = info.Active;
                    courseToUpdate.LastUpdateDt = DateTime.Now;

                    _context.SaveChanges();
                }
            }
        }

        /*  PRIVATE METHODS */
        private void SaveNewCourse(CourseDetailsViewModel info)
        {
            Course track = new Course()
            {
                Name = info.Name,
                Tee = info.Tee,
                Rating = info.Rating,
                Slope = info.Slope,
                Active = true,
                CreateDt = DateTime.Now,
                LastUpdateDt = DateTime.Now
            };

            _context.Course.Add(track);
            _context.SaveChanges();
        }
    }
}
