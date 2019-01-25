using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.Controllers
{

    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPlayerService _playerservice;

        public PlayerController(ApplicationDbContext context, IPlayerService playerservice)
        {
            _context = context;
            _playerservice = playerservice;
        }

        // GET: Player
        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");
            var list = await _context.PlayerModel.ToListAsync();
            if (!list.Exists(a=> a.User == ControllerContext.HttpContext.User.Identity.Name))
            {
                return View("CreatePlayer");
            }

            var item = _playerservice.GetPlayerInfo(ControllerContext.HttpContext.User.Identity.Name, list, _context);
            return View("Index", item);

        }

        [HttpPost]
        public IActionResult CreatePlayer(PlayerModel model)
        {
            model.User = ControllerContext.HttpContext.User.Identity.Name;
            model.Elo = 1600;
            model.HasVoted = false;
            _context.PlayerModel.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
