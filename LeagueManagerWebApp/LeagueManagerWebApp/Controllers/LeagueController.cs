using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var list = _context.LeagueModel.First(a =>
                    a.Players.Contains(_context.PlayerModel
                        .First(b => b.User == ControllerContext.HttpContext.User.Identity.Name).Name));
                var players = list.Players.Split(',');
                List<PlayerModel> playersList = (from elem in players where _context.PlayerModel.ToList().Exists(a => a.Name == elem) select _context.PlayerModel.ToList().First(a => a.Name == elem)).ToList();

                var final = playersList.OrderBy(o => o.Elo).Reverse().ToList();
                return View("LeagueView", final);
            }

            return Redirect("/Identity/Account/Login");
        }
    }
}