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
            return new CourseAdminViewModel();
        }
    }
}
