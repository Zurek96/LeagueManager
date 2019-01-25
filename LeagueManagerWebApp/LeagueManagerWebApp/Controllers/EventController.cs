using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Dto;
using LeagueManagerWebApp.Interfaces;

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

                return View("Voting", dto);
            }

            return View("AlreadyVoted", _context.VotingModel.First(a => a.Id == id));
        }

        [HttpPost]
        public IActionResult SubmitVote(VotingDto model)
        {
            if (_eventService.SubmitVote(model, _context, ControllerContext.HttpContext.User.Identity.Name))
            {
                return View("Index");
            }

            return View("PollClosed");
        }
    }
}
