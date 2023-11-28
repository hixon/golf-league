using AutoMapper;
using golf_league.Infrastructure;
using golf_league.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace golf_league.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMapper mapper { get; set; }
        private IGolfRepository repo { get; set; }
        private IConfiguration _config { get; }

        public HomeController(ILogger<HomeController> logger, IMapper mapper, ApplicationDbContext ctx, IConfiguration _con)
        {
            _logger = logger;
            this.mapper = mapper;
            repo = new GolfRepository(ctx, mapper, _con);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ScoreCard()
        {
            var info = repo.GetScoreCardDetails(new Guid("ef8429c4-8ebb-42c6-79a2-08dbd5c07428"));

            return View(info);
        }
    }
}