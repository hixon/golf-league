using AutoMapper;
using golf_league.Infrastructure;
using golf_league.Models;
using golf_league.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace golf_league.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private IMapper mapper { get; set; }
        private IGolfRepository repo { get; set; }
        private IConfiguration _config { get; }

        public ScoreController(ILogger<HomeController> logger, IMapper mapper, ApplicationDbContext ctx, IConfiguration _con)
        {
            _logger = logger;
            this.mapper = mapper;
            repo = new GolfRepository(ctx, mapper, _con);
        }

        [HttpPost]
        public IActionResult Post(PlayerScoreDetailsViewModel scoredetails)
        {
            //take input and parse it to an ienumerable
            //save all details 
            //return 200 message if it worked otherwise an error

            var playerScore = scoredetails;
            //foreach(var playerScore in scoredetails)
            //{
                repo.SaveDetails(playerScore);
            //}

            return Ok();
        }
    }
}
