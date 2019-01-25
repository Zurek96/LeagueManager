using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.ViewModels;

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
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(await _context.AchievementModel.ToListAsync());
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
                Players = _context.PlayerModel.ToList(), Achievements = _context.AchievementModel.ToList()
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
            return View("Index", _context.AchievementModel.ToList());
        }
    }
}
