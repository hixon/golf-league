﻿using AutoMapper;
using golf_league.Models;
using golf_league.ViewModels;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Text.Json;

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
            var allcourses = GetAllCourses();

            return new CourseAdminViewModel()
            {
                Courses = allcourses,
                AllCourses = JsonSerializer.Serialize(allcourses),
                Tees = JsonSerializer.Serialize(GetAllTees()),
            };
        }

        public Course GetCourseById(Guid courseId)
        {
            return _context.Course.Where(c => c.Id == courseId).First();
        }

        public IEnumerable<Tee> GetTeesByCourseId(Guid courseId)
        {
            return _context.Tee.Where(t => t.CourseId == courseId).ToList();
        }

        public IEnumerable<HoleInfo> GetHoleInfoByCourseId(Guid courseId)
        {
            List<HoleInfo> allHoles = new List<HoleInfo>();

            IEnumerable<Tee> Tees = GetTeesByCourseId(courseId);

            foreach(var tee in Tees)
            {
                allHoles.AddRange(GetAllHolesByTeeId(tee.Id));
            }

            return allHoles;
        }

        public PlayerAdminViewModel GetPlayers()
        {
            var allPlayers = _context.Player
                .ToList();

            var allTypes = GetPlayerTypes();

            return new PlayerAdminViewModel()
            {
                Players = allPlayers,
                PlayerTypes = allTypes
            };
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return _context.Player.ToList();
        }

        public ScoreCardViewModel GetScoreCardDetails(Guid courseId) //pick westy since we always play there
        {
            var allTees = GetTeesByCourseId(courseId);
            var allHoles = GetHoleInfoByCourseId(courseId);
            var allPlayers = GetAllPlayers();

            return new ScoreCardViewModel()
            {
                Course = GetCourseById(courseId),
                Tees = allTees,
                Holes = allHoles,
                Players = allPlayers, 
                TeesJson = JsonSerializer.Serialize(allTees),
                HolesJson = JsonSerializer.Serialize(allHoles),
                PlayersJson = JsonSerializer.Serialize(allPlayers),
            };
        }

        public void SaveDetails(PlayerScoreDetailsViewModel details)
        {
            //add Score for player
            var scoreToAdd = _mapper.Map<Score>(details);
            scoreToAdd.Active = true;
            scoreToAdd.CreateDt = DateTime.Now;

            _context.Score.Add(scoreToAdd);
            _context.SaveChanges();

            Guid addedRowId = scoreToAdd.Id;
            
            //add all scores for each hole
            foreach(var hole in details.Holes)
            {
                ScoreDetail holeScoreToAdd = _mapper.Map<ScoreDetail>(hole);
                holeScoreToAdd.ScoreId = addedRowId;
                 
                _context.ScoreDetail.Add(holeScoreToAdd);
            }

            _context.SaveChanges();

            //update player.currindex
            UpdatePlayerIndex(details.PlayerId);
        }

        private void UpdatePlayerIndex(Guid pId)
        {
            //calculation - https://www.usga.org/handicapping/roh/rules-of-handicapping.html

            //we only care about the last 20 scores
            var past20Scores = _context.Score
                .Where(s => s.PlayerId == pId)
                .OrderByDescending(s => s.DatePlayed)
                .Take(20)
                .ToList();

            var player = _context.Player.Where(p => p.Id == pId).Single();

            //
            int rounds = past20Scores.Count;
            decimal index = 0;

            if (rounds == 3)
            {
                //lowest 1 -2 strokes
                index = past20Scores.Min(s => s.Differential) - 2;
            }
            else if (rounds == 4)
            {
                //lowest 1 - 1 stroke
                index = past20Scores.Min(s => s.Differential) - 1;
            }
            else if (rounds == 5)
            {
                //lowest 1
                index = past20Scores.Min(s => s.Differential);
            }
            else if (rounds == 6)
            {
                //avg low 2 - 1
                index = past20Scores.OrderBy(s => s.Differential).Take(2).Sum(s => s.Differential) - 1;
            }
            else if (rounds == 7 || rounds == 8)
            {
                //avg low 2
                index = past20Scores.OrderBy(s => s.Differential).Take(2).Sum(s => s.Differential);
            }
            else if (rounds >= 9 && rounds <= 11)
            {
                //avg low 3
                index = past20Scores.OrderBy(s => s.Differential).Take(3).Sum(s => s.Differential);
            }
            else if (rounds >= 12 && rounds <= 14)
            {
                //avg low 4
                index = past20Scores.OrderBy(s => s.Differential).Take(4).Sum(s => s.Differential);
            }
            else if (rounds == 15 || rounds == 16)
            {
                //avg low 5
                index = past20Scores.OrderBy(s => s.Differential).Take(5).Sum(s => s.Differential);
            }
            else if (rounds == 17 || rounds == 18)
            {
                //avg low 6
                index = past20Scores.OrderBy(s => s.Differential).Take(6).Sum(s => s.Differential);
            }
            else if (rounds == 19)
            {
                //avg low 7
                index = past20Scores.OrderBy(s => s.Differential).Take(7).Sum(s => s.Differential);
            }
            else if (rounds == 20)
            {
                //avg low 8
                index = past20Scores.OrderBy(s => s.Differential).Take(8).Sum(s => s.Differential);
            }
            else
            {
                //number of rounds is less than three
                //not sure what to do here
                index = (decimal)player.CurrIndex;
            }

            //update with index 
            if(player.CurrIndex != index)
            {
                player.CurrIndex = index;
                player.LastUpdateDt = DateTime.Now;

                _context.SaveChanges();
            }
        }

        public IEnumerable<PlayerType> GetPlayerTypes()
        {
            return _context.PlayerType.Where(p => p.Active == true).ToList();
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
                    //courseToUpdate.Tee = info.Tee;
                    //courseToUpdate.Rating = info.Rating;
                    //courseToUpdate.Slope = info.Slope;
                    courseToUpdate.Active = info.Active;
                    courseToUpdate.LastUpdateDt = DateTime.Now;

                    _context.SaveChanges();
                }
            }
        }

        public void SavePlayer(PlayerDetailsViewModel info)
        {
            if (info.Id == Guid.Empty)
            {
                //Save new Course
                SaveNewPlayer(info);
            }
            else
            {
                //get course and save any changes
                Player playerToUpdate = _context.Player.Where(c => c.Id == info.Id).FirstOrDefault();

                if (playerToUpdate is null)
                {
                    SaveNewPlayer(info);
                }
                else
                {
                    //replace w/ automapper call
                    playerToUpdate.FirstName = info.FirstName;
                    playerToUpdate.LastName = info.LastName;
                    playerToUpdate.StartIndex = info.StartIndex;
                    playerToUpdate.CurrIndex = info.CurrIndex;
                    playerToUpdate.PlayerTypeId = info.PlayerTypeId;
                    playerToUpdate.Active = info.Active;
                    playerToUpdate.LastUpdateDt = DateTime.Now;

                    _context.SaveChanges();
                }
            }
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Course
                .Where(c => c.Active == true)
                .OrderBy(c => c.Name)
                .ToList();
        }

        private IEnumerable<Tee> GetAllTees()
        {
            return _context.Tee.Where(t => t.Active == true).ToList();
        }

        /*  PRIVATE METHODS */
        private IEnumerable<HoleInfo> GetAllHolesByTeeId(Guid teeId)
        {
            return _context.HoleInfo.Where(h => h.TeeId == teeId).OrderBy(t => t.Number).ToList(); 
        }
        private void SaveNewCourse(CourseDetailsViewModel info)
        {
            Course track = new Course()
            {
                Name = info.Name,
                //Tee = info.Tee,
                //Rating = info.Rating,
                //Slope = info.Slope,
                Active = true,
                CreateDt = DateTime.Now,
                LastUpdateDt = DateTime.Now
            };

            _context.Course.Add(track);
            _context.SaveChanges();
        }

        private void SaveNewPlayer(PlayerDetailsViewModel info)
        {
            Player person = new Player()
            {
                FirstName = info.FirstName,
                LastName = info.LastName,
                StartIndex = info.StartIndex,
                CurrIndex = info.CurrIndex,
                PlayerTypeId = info.PlayerTypeId,
                Active = true,
                CreateDt = DateTime.Now,
                LastUpdateDt = DateTime.Now
            };

            _context.Player.Add(person);
            _context.SaveChanges();
        }
    }
}
