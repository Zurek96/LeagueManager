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
            return View(_viewModel);
        }

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

        public IActionResult PlayerEditor()
        {
            return View("PlayerEditorView", _context.PlayerModel.ToList());
        }

        public IActionResult AchievementEditor()
        {
            return View("AchievementEditorView", _context.AchievementModel.ToList());
        }

        public IActionResult LeagueEditor()
        {
            return View("LeagueEditorView", _context.LeagueModel.ToList());
        }

        public IActionResult LeagueStarter()
        {
            return View("LeagueStarterView", _context.LeagueModel.ToList());
        }

        public async Task<IActionResult> AddScore()
        {

            var a = _context.MatchupModel.ToList();

            var viewModel = new ScoreViewModel(null, _context.LeagueModel.ToList());
            
            return View("ScoreView", viewModel);
        }

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
            var original = _context.PlayerModel.ToList().First(a => a.Name == model.Name);
            if (original!= model && original!=null)
            {
                _context.PlayerModel.Update(original);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditAchievement(AchievementModel model)
        {
            var original = _context.AchievementModel.ToList().First(a => a.Name == model.Name);
            if (original != model && original != null)
            {
                _context.AchievementModel.Update(original);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditLeague(LeagueModel model)
        {
            var original = _context.LeagueModel.ToList().First(a => a.Name == model.Name);
            if (original != model && original != null)
            {
                _context.LeagueModel.Update(original);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> StartLeague(LeagueModel model)
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
                    tmp.League = starter;
                    tmp.IsFinished = false;
                    _context.MatchupModel.Add(tmp);
                    _context.SaveChanges();
                }
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> GetLeagueMatchups(LeagueModel league)
        {
            var chosenLeague = _context.LeagueModel.First(a=>a.Name==league.Name);
            var viewModel = new ScoreViewModel(_context.MatchupModel.ToList().Where(a=>a.League == chosenLeague).ToList(), _context.LeagueModel.ToList());
            

            return View("ScoreView", viewModel);
        }

        
        
        public IActionResult AddScoreFinal(int? id)
        {
            var model = _context.MatchupModel.Find(id);
            return View("ScoreSheetView",model);
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
            return RedirectToAction("Index");
        }
    }
}