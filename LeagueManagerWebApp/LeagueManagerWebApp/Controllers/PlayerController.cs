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

                var item = await _playerservice.GetPlayerInfo(ControllerContext.HttpContext.User.Identity.Name, list);
                return View("Index", item);
            }

            return Redirect("/Identity/Account/Login");
        }

        // GET: Player/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerModel = await _context.PlayerModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playerModel == null)
            {
                return NotFound();
            }

            return View(playerModel);
        }

        // GET: Player/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Elo,AchievementScore,Wins,Losses,MatchesPlayed")] PlayerModel playerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playerModel);
        }

        // GET: Player/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerModel = await _context.PlayerModel.FindAsync(id);
            if (playerModel == null)
            {
                return NotFound();
            }
            return View(playerModel);
        }

        // POST: Player/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Elo,AchievementScore,Wins,Losses,MatchesPlayed")] PlayerModel playerModel)
        {
            if (id != playerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerModelExists(playerModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(playerModel);
        }

        // GET: Player/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerModel = await _context.PlayerModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playerModel == null)
            {
                return NotFound();
            }

            return View(playerModel);
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
