using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeagueManagerWebApp.Controllers
{
    [Authorize(Policy = "RequireAdmin")]
    
    public class AdministratorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private AdminViewModel _viewModel = new AdminViewModel();

        public AdministratorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            _viewModel.LeagueList = await _context.LeagueModel.ToListAsync();
            _viewModel.PlayerList = await _context.PlayerModel.ToListAsync();
            _viewModel.AchievementList = await _context.AchievementModel.ToListAsync();
            _viewModel.EventsList = await _context.EventModel.ToListAsync();
            return View(_viewModel);
        }

        #region VIEWS

        public IActionResult PlayerCreator()
        {
            return View("PlayerCreatorView");
        }

        public IActionResult AchievementsCreator()
        {
            return View("AchievementsCreatorView");
        }

        public IActionResult LeagueCreator()
        {
            return View("LeagueCreatorView");
        }

        public IActionResult PlayerEditor(int? id)
        {
            return View("PlayerEditorView", id);
        }

        public IActionResult AchievementEditor(int? id)
        {
            return View("AchievementEditorView", id);
        }

        public IActionResult LeagueEditor(int? id)
        {
            return View("LeagueEditorView", id);
        }

        public IActionResult LeagueStarter()
        {
            return View("LeagueStarterView", _context.LeagueModel.ToList());
        }

        public IActionResult AddScore()
        {

            var a = _context.MatchupModel.ToList();

            var viewModel = new ScoreViewModel(null, _context.LeagueModel.ToList());
            
            return View("ScoreView", viewModel);
        }

        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> CreatePlayer(PlayerModel model)
        {
            model.Elo = 1600;
            model.AchievementScore = 0;
            model.Losses = 0;
            model.MatchesPlayed = 0;
            model.Wins = 0;
            _context.PlayerModel.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAchievement(AchievementModel model)
        {
            _context.AchievementModel.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateLeague(LeagueModel model)
        {
            if (_context.PlayerModel.ToList().Count == 1)
            {
                return View("PlayersError");
            }
            _context.LeagueModel.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditPlayer(PlayerModel model)
        {
            var original = _context.PlayerModel.Find(model.Id);
            if (model.Elo != original.Elo && model.Elo != 0) 
            {
                original.Elo = model.Elo;
            }
            if (model.MatchesPlayed != original.MatchesPlayed && model.MatchesPlayed != 0)
            {
                original.MatchesPlayed = model.MatchesPlayed;
            }
            if (model.Wins != original.Wins && model.Wins != 0)
            {
                original.Wins = model.Wins;
            }
            if (model.Losses != original.Losses && model.Losses != 0)
            {
                original.Losses = model.Losses;
            }
            if (model.HasVoted != original.HasVoted)
            {
                original.HasVoted = model.HasVoted;
            }

            
            _context.PlayerModel.Update(original);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditAchievement(AchievementModel model)
        {
            var original = _context.AchievementModel.Find(model.Id);
            if (model.Points != original.Points && model.Points != 0)
            {
                original.Points = model.Points;
            }
            if (model.Description != original.Description && model.Description != null)
            {
                original.Description = model.Description;
            }
            _context.AchievementModel.Update(original);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            
            
        }

        [HttpPost]
        public async Task<IActionResult> EditLeague(LeagueModel model)
        {
            var original = _context.LeagueModel.Find(model.Id);
            if (model.Players != original.Players && model.Players != null)
            {
                original.Players = model.Players;
            }
            _context.LeagueModel.Update(original);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult DeletePlayer(int? id)
        {
            var model = _context.PlayerModel.Find(id);
            _context.PlayerModel.Remove(model);
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(PlayerModel, RESEED, 0)");
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteLeague(int? id)
        {
            var model = _context.LeagueModel.Find(id);
            var matchups = _context.MatchupModel.ToList();
            foreach (var elem in matchups.Where(a => a.LeagueName == model.Name))
            {
                _context.MatchupModel.Remove(elem);
            }
            _context.LeagueModel.Remove(model);
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(LeagueModel, RESEED, 0)");
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAchievement(int? id)
        {
            var model = _context.AchievementModel.Find(id);
            _context.AchievementModel.Remove(model);
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(AchievementModel, RESEED, 0)");
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEvent(int? id)
        {
            var model = _context.EventModel.Find(id);
            foreach (var elem in model.Matchups.Split(','))
            {
                if (elem == "") continue;
                _context.MatchupModel.Remove(_context.MatchupModel.Find(Convert.ToInt32(elem)));
                _context.SaveChanges();
            }
            _context.EventModel.Remove(model);
            foreach (var elem in _context.VotingModel.ToList().Where(a => a.Event == model))
            {
                _context.VotingModel.Remove(elem);
            }
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(VotingModel, RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(EventModel, RESEED, 0)");

            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(MatchupModel, RESEED, 0)");
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

        [HttpPost]
        public IActionResult StartLeague(LeagueModel model)
        {
            var starter = _context.LeagueModel.ToList().First(a => a.Name == model.Name);
            var playersSplit = starter.Players.Split(',');
            List<MatchupModel> matchup = new List<MatchupModel>();
            List<PlayerModel> players = new List<PlayerModel>();
            foreach (var elem in playersSplit)
            {
                foreach (var player in _context.PlayerModel.ToList().Where(a => a.Name == elem))
                {
                    players.Add(player);
                }
            }

            foreach (var player1 in players)
            {
                foreach (var player2 in players)
                {
                    if (player1 == player2) continue;
                    if (_context.MatchupModel.ToList().Exists(a =>
                        a.Player1 == player1.Name && a.Player2 == player2.Name || a.Player1 == player2.Name && a.Player2 == player1.Name ))
                        continue;
                    var tmp = new MatchupModel();
                    tmp.Player1 = player1.Name;
                    tmp.Player2 = player2.Name;
                    tmp.LeagueName = starter.Name;
                    tmp.IsFinished = false;
                    matchup.Add(tmp);
                    _context.MatchupModel.Add(tmp);
                    _context.SaveChanges();
                }
            }

            var Event = new EventModel();
            DateTime today = DateTime.Today;
            int daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)today.DayOfWeek + 7) % 7;
            Event.Date = today.AddDays(daysUntilTuesday);
            foreach (var elem in matchup)
            {
                Event.Matchups = Event.Matchups + elem.Id + ',';

            }

            Event.Format = VotingModel.Formats.Standard;
            Event.LeagueName = starter.Name;
            Event.isFinished = false;

            var voting = new VotingModel();
            voting.Event = Event;
            voting.IsOpened = true;

            _context.VotingModel.Add(voting);

            _context.EventModel.Add(Event);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GetLeagueMatchups(LeagueModel league)
        {
            var chosenLeague = _context.LeagueModel.First(a=>a.Name==league.Name);
            var viewModel = new ScoreViewModel(_context.MatchupModel.ToList().Where(a=>a.LeagueName == chosenLeague.Name).ToList(), _context.LeagueModel.ToList());
            

            return View("ScoreView", viewModel);
        }

        
        
        public IActionResult AddScoreFinal(int? id, int EventId)
        {
            var model = _context.MatchupModel.First(a=>a.Id==id);

            return View("ScoreSheetView", model);

        }

        [HttpPost]
        public IActionResult SubmitScore(MatchupModel model)
        {
            var S1 = 1;
            var S2 = 0;
            PlayerModel player1 = _context.PlayerModel.First(a => a.Name == model.Player1);
            PlayerModel player2 = _context.PlayerModel.First(a => a.Name == model.Player2);
            if (model.Winner == model.Player1)
            {
                model.Loser = model.Player2;
                player1.MatchesPlayed++;
                player2.MatchesPlayed++;
                player2.Losses++;
                player1.Wins++;
                var diff = player1.Elo - player2.Elo;
                var percW = 1 / (1 + Math.Pow(10, diff / 400));
                var percL = 1 / (1 + Math.Pow(10, player2.Elo - player1.Elo) / 400);
                var k = 32;

                player1.Elo =(int) Math.Floor(player1.Elo + k * (S1 - percW));
                player2.Elo = (int)Math.Floor(player2.Elo + k * (S2 - percL));
            }
            else
            {
                model.Loser = model.Player1;
                player1.MatchesPlayed++;
                player2.MatchesPlayed++;
                player1.Losses++;
                player2.Wins++;
                var diff = player2.Elo - player1.Elo;
                var percW = 1 / (1 + Math.Pow(10, diff / 400));
                var percL = 1 / (1 + Math.Pow(10, player1.Elo - player2.Elo) / 400);
                var k = 32;

                player2.Elo = (int)Math.Floor(player2.Elo + k * (S1 - percW));
                player1.Elo = (int)Math.Floor(player1.Elo + k * (S2 - percL));
            }

            model.IsFinished = true;
           
            _context.PlayerModel.Update(player1);
            _context.PlayerModel.Update(player2);

            _context.MatchupModel.Update(model);
            _context.SaveChanges();
            if (!_context.MatchupModel.ToList().Exists(a => a.LeagueName == model.LeagueName && a.IsFinished==false))
            {
                var b = _context.EventModel.First(a => a.LeagueName == model.LeagueName);
                b.isFinished = true;
                _context.EventModel.Update(b);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }



        public IActionResult StartEvent(int? id)
        {
            var viewModel = new EventViewModel();
            var model = _context.EventModel.Find(id);
            var matchups = new List<MatchupModel>();
            foreach (var elem in model.Matchups.Split(','))
            {
                if (_context.MatchupModel.ToList().Exists(a => a.Id.ToString() == elem))
                {
                    matchups.Add(_context.MatchupModel.Find(Convert.ToInt32(elem)));
                }
            }

            viewModel.Matchups = matchups;
            viewModel.Event = model;
            return View(viewModel);
        }

        public IActionResult CloseVoting(int? id)
        {
            var Event = _context.EventModel.Find(id);
            var voting = new VotingModel();
            foreach (var elem in _context.VotingModel.ToList().Where(a => a.Event == Event))
            {
                voting = elem;
            }

            if (voting.IsOpened)
            {
                voting.IsOpened = false;
                Dictionary<VotingModel.Formats, int> results = new Dictionary<VotingModel.Formats, int>();
                results.Add(VotingModel.Formats.Standard, voting.Stand);
                results.Add(VotingModel.Formats.Modern, voting.Mod);
                results.Add(VotingModel.Formats.Pauper, voting.Pau);
                results.Add(VotingModel.Formats.Rainbow, voting.Rain);
                results.Add(VotingModel.Formats.Draft, voting.Draft);
                results.Add(VotingModel.Formats.Singleton, voting.Sing);
                results.Add(VotingModel.Formats.Tribal, voting.Tri);
                results.Add(VotingModel.Formats.Peasant, voting.Pea);
                results.Add(VotingModel.Formats.Warband, voting.War);
                results.Add(VotingModel.Formats.Backdraft, voting.Back);

                Event.Format = results.Keys.First();

                foreach (var elem in results)
                {
                    if (elem.Value > results[Event.Format])
                    {
                        Event.Format = elem.Key;
                    }
                }

                _context.VotingModel.Update(voting);
                _context.EventModel.Update(Event);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}