using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Models;
using Microsoft.AspNetCore.Authorization;

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

        // GET: Achievement/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievementModel = await _context.AchievementModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (achievementModel == null)
            {
                return NotFound();
            }

            return View(achievementModel);
        }

        // GET: Achievement/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Achievement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] AchievementModel achievementModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(achievementModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(achievementModel);
        }

        // GET: Achievement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievementModel = await _context.AchievementModel.FindAsync(id);
            if (achievementModel == null)
            {
                return NotFound();
            }
            return View(achievementModel);
        }

        // POST: Achievement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] AchievementModel achievementModel)
        {
            if (id != achievementModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(achievementModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AchievementModelExists(achievementModel.Id))
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
            return View(achievementModel);
        }

        // GET: Achievement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievementModel = await _context.AchievementModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (achievementModel == null)
            {
                return NotFound();
            }

            return View(achievementModel);
        }

        // POST: Achievement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var achievementModel = await _context.AchievementModel.FindAsync(id);
            _context.AchievementModel.Remove(achievementModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AchievementModelExists(int id)
        {
            return _context.AchievementModel.Any(e => e.Id == id);
        }
    }
}
