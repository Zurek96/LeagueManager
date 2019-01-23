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

    public class MatchupController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatchupController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Matchup
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(await _context.MatchupModel.ToListAsync());
            }

            return Redirect("/Identity/Account/Login");
        }

        // GET: Matchup/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchupModel = await _context.MatchupModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchupModel == null)
            {
                return NotFound();
            }

            return View(matchupModel);
        }

        // GET: Matchup/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Matchup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsFinished,Date")] MatchupModel matchupModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchupModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchupModel);
        }

        // GET: Matchup/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchupModel = await _context.MatchupModel.FindAsync(id);
            if (matchupModel == null)
            {
                return NotFound();
            }
            return View(matchupModel);
        }

        // POST: Matchup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsFinished,Date")] MatchupModel matchupModel)
        {
            if (id != matchupModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matchupModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchupModelExists(matchupModel.Id))
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
            return View(matchupModel);
        }

        // GET: Matchup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchupModel = await _context.MatchupModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchupModel == null)
            {
                return NotFound();
            }

            return View(matchupModel);
        }

        // POST: Matchup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchupModel = await _context.MatchupModel.FindAsync(id);
            _context.MatchupModel.Remove(matchupModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchupModelExists(int id)
        {
            return _context.MatchupModel.Any(e => e.Id == id);
        }
    }
}
