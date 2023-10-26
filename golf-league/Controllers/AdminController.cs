using Microsoft.AspNetCore.Mvc;
using golf_league.Models;
using golf_league.Infrastructure;
using AutoMapper;
using golf_league.ViewModels;

namespace golf_league.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private IMapper mapper { get; set; }
        private IGolfRepository repo { get; set; }
        private IConfiguration _config { get; }

        public AdminController(ILogger<AdminController> logger, IMapper mapper, ApplicationDbContext ctx, IConfiguration _con)
        {
            _logger = logger;
            this.mapper = mapper;
            repo = new GolfRepository(ctx, mapper, _con);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Course()
        {
            var courses = repo.GetCourses();

            return View(courses);
        }

        [HttpPost]
        public IActionResult SaveCourse(CourseAdminViewModel vm)
        {
            repo.SaveCourse(vm.Details);

            return Redirect("Course");
        }
    }
}
