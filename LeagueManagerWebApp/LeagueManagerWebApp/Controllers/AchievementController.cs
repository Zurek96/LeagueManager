﻿using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LeagueManagerWebApp.Controllers
{
    public class AchievementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AchievementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Achievement
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(_context.AchievementModel.ToList().OrderBy(a => a.Points).Reverse());
            }

            return Redirect("/Identity/Account/Login");
        }

        public IActionResult ShowStandings()
        {
            var playersList = _context.PlayerModel.ToList();
            var output = playersList.OrderBy(o => o.AchievementScore).Reverse().ToList();

            return View("StandingsView", output);
        }

        public IActionResult AddAchievement()
        {
            var viewModel = new AchievementsViewModel
            {
                Players = _context.PlayerModel.ToList(),
                Achievements = _context.AchievementModel.ToList()
            };
            return View("AttachAchievement", viewModel);
        }

        [HttpPost]
        public IActionResult SubmitAchievement(string PlayerName, string AchievementName)
        {
            var player = _context.PlayerModel.First(o => o.Name == PlayerName);
            var achievement = _context.AchievementModel.First(o => o.Name == AchievementName);
            player.AchievementScore += achievement.Points;
            player.Achievements = player.Achievements + "|" + AchievementName;
            _context.PlayerModel.Update(player);
            _context.SaveChanges();
            var output = _context.AchievementModel.ToList();

            return View("Index", output.OrderBy(a => a.Points));
        }
    }
}