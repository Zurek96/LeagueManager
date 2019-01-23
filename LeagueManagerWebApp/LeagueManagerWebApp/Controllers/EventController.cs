using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Dto;
using LeagueManagerWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace LeagueManagerWebApp.Controllers
{
    
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Event
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {

                return View(await _context.EventModel.ToListAsync());
            }

            return Redirect("/Identity/Account/Login");
        }

        public IActionResult Voting(int? id)
        {
            var model = _context.VotingModel.First(a => a.Id == id);
            var dto = new VotingDto();
            dto.Id = model.Id;

            return View("Voting", dto);
        }

        [HttpPost]
        public IActionResult SubmitVote(VotingDto model)
        {
            var Voting = _context.VotingModel.Find(model.Id);
            if (Voting.IsOpened)
            {
                if (model.Stand) Voting.Stand++;
                if (model.Mod) Voting.Mod++;
                if (model.Pau) Voting.Pau++;
                if (model.Rain) Voting.Rain++;
                if (model.Draft) Voting.Draft++;
                if (model.Sing) Voting.Sing++;
                if (model.Tri) Voting.Tri++;
                if (model.Pea) Voting.Pea++;
                if (model.War) Voting.War++;
                if (model.Back) Voting.Back++;

                _context.VotingModel.Update(Voting);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("PollClosed");
        }
    }
}
