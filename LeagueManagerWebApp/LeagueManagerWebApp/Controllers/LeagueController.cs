using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace LeagueManagerWebApp.Controllers
{

    public class LeagueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeagueController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: League
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {

                return View(await _context.LeagueModel.ToListAsync());
            }

            return Redirect("/Identity/Account/Login");
        }

        [HttpPost]
        public IActionResult ViewLeagueStandings(LeagueModel model)
        {
            var league = _context.LeagueModel.First(a => a.Name == model.Name);
            var players = league.Players.Split(',');
            List<PlayerModel> playersList = new List<PlayerModel>();
            foreach (var elem in players)
            {
                if (_context.PlayerModel.ToList().Exists(a=>a.Name==elem))
                {
                    playersList.Add(_context.PlayerModel.ToList().First(a=> a.Name==elem));
                }
            }

            var final = playersList.OrderBy(o => o.Elo).Reverse().ToList();
            return View("LeagueView", final);
        }

        
    }
}
