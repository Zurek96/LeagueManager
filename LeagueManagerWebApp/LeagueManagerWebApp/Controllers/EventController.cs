using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Dto;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.ViewModels;

namespace LeagueManagerWebApp.Controllers
{
    
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEventService _eventService;

        public EventController(ApplicationDbContext context, IEventService eventService)
        {
            _eventService = eventService;
            _context = context;
        }

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
            if (_context.PlayerModel.First(a => a.User == ControllerContext.HttpContext.User.Identity.Name).HasVoted ==
                false)
            {
                var model = _context.VotingModel.First(a => a.Id == id);
                var dto = new VotingDto();
                dto.Id = model.Id;
                dto.EventId = Convert.ToInt32(id);
                return View("Voting", dto);
            }

            return View("AlreadyVoted", _context.VotingModel.First(a => a.Id == id));
        }

        [HttpPost]
        public IActionResult SubmitVote(VotingDto model)
        {
            if (_eventService.SubmitVote(model, _context, _context.PlayerModel.First(a=>a.User == ControllerContext.HttpContext.User.Identity.Name).Name))
            {
                return View("Index", _context.EventModel.ToList());
            }

            return View("PollClosed");
        }

        public IActionResult VotingResults(int? id)
        {
            var viewmodel = new VotingResultViewModel();
            var model = _context.VotingModel.Find(id);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Backdraft",model.Back);
            dict.Add("Standard", model.Stand);
            dict.Add("Modern", model.Mod);
            dict.Add("Pauper", model.Pau);
            dict.Add("Rainbow", model.Rain);
            dict.Add("Draft", model.Draft);
            dict.Add("Singleton", model.Sing);
            dict.Add("Tribal", model.Tri);
            dict.Add("Peasant", model.Pea);
            dict.Add("Warband", model.War);
            Dictionary<string, int> output = dict.OrderBy(o => o.Value).Reverse().ToDictionary(p => p.Key,o=>o.Value);
            viewmodel.formats = output;
            viewmodel.winner = model.Winner;
            return View("VotingResult", viewmodel);

        }
    }
}
