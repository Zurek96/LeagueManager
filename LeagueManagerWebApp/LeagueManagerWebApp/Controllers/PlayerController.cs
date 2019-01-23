using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

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
            if (User.Identity.IsAuthenticated)
            {
                var a = await _context.Users.ToListAsync();
                a.Find(b => b.UserName == "a");
                var list = await _context.PlayerModel.ToListAsync();
                if (list.Count == 0)
                {
                    return View("NullErrorView");
                }

                var item = _playerservice.GetPlayerInfo(ControllerContext.HttpContext.User.Identity.Name, list);
                return View("Index", item);
            }

            return Redirect("/Identity/Account/Login");
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playerModel = await _context.PlayerModel.FindAsync(id);
            _context.PlayerModel.Remove(playerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerModelExists(int id)
        {
            return _context.PlayerModel.Any(e => e.Id == id);
        }
    }
}
