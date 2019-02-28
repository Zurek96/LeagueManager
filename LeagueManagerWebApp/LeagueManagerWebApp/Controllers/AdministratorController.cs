using System;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeagueManagerWebApp.Controllers
{


    public class AdministratorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAdministratorService _administratorService;
        private readonly AdminViewModel _viewModel = new AdminViewModel();

        public AdministratorController(ApplicationDbContext context, IAdministratorService administratorService)
        {
            _administratorService = administratorService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Admin"))
            {
                _viewModel.LeagueList = await _context.LeagueModel.ToListAsync();
                _viewModel.PlayerList = await _context.PlayerModel.ToListAsync();
                _viewModel.AchievementList = await _context.AchievementModel.ToListAsync();
                _viewModel.EventsList = await _context.EventModel.ToListAsync();
                return View(_viewModel);
            }

            return View("AccessDenied");
        }

        #region VIEWS

        public IActionResult PlayerCreator()
        {
            return View("PlayerCreatorView");
        }

        public IActionResult AchievementsCreator()
        {
            return View("AchievementsCreatorView");
        }

        public IActionResult LeagueCreator()
        {
            return View("LeagueCreatorView");
        }

        public IActionResult PlayerEditor(int? id)
        {
            return View("PlayerEditorView", id);
        }

        public IActionResult AchievementEditor(int? id)
        {

            return View("AchievementEditorView", _context.AchievementModel.Find(id));
        }

        public IActionResult LeagueEditor(int? id)
        {
            return View("LeagueEditorView", id);
        }

        public IActionResult LeagueStarter()
        {
            return View("LeagueStarterView", _context.LeagueModel.ToList());
        }

        public IActionResult AddScore()
        {
            var viewModel = new ScoreViewModel(null, _context.LeagueModel.ToList());
            
            return View("ScoreView", viewModel);
        }

        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> CreatePlayer(PlayerModel model)
        {
            await _administratorService.CreatePlayer(model, _context);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAchievement(AchievementModel model)
        {
            await _administratorService.CreateAchievement(model, _context);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateLeague(LeagueModel model)
        {
            var result = await _administratorService.CreateLeague(model, _context);
            if (result == 1)
            {
                return View("PlayersError");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditPlayer(PlayerModel model)
        {
            await _administratorService.EditPlayer(model, _context);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditAchievement(AchievementModel model)
        {
            await _administratorService.EditAchievement(model, _context);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditLeague(LeagueModel model)
        {
            await _administratorService.EditLeague(model, _context);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePlayer(int? id)
        {
            _administratorService.DeletePlayer(id, _context);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteLeague(int? id)
        {
            _administratorService.DeleteLeague(id, _context);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAchievement(int? id)
        {
            _administratorService.DeleteAchievement(id, _context);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEvent(int? id)
        {
            _administratorService.DeleteEvent(id, _context);
            return RedirectToAction("Index");
        }

        #endregion

        [HttpPost]
        public IActionResult StartLeague(LeagueModel model)
        {
            _administratorService.StartLeague(model, _context);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GetLeagueMatchups(LeagueModel league)
        {
            var chosenLeague = _context.LeagueModel.First(a=>a.Name==league.Name);
            var viewModel = new ScoreViewModel(_context.MatchupModel.ToList().Where(a=>a.LeagueId == chosenLeague.Id).ToList(), _context.LeagueModel.ToList());
            return View("ScoreView", viewModel);
        }
    
        public IActionResult AddScoreFinal(int? id, int EventId)
        {
            var model = _context.MatchupModel.First(a=>a.Id==id);
            return View("ScoreSheetView", model);
        }

        [HttpPost]
        public IActionResult PrepareMatchup(string EventId, string Player1, string Player2)
        {
            var matchup = new MatchupModel();
            matchup.Player1 = Player1;
            matchup.Player2 = Player2;
            matchup.Winner = Player1;
            matchup.EventId = Convert.ToInt32(EventId);
            return SubmitScore(matchup);
        }

        
        public IActionResult SubmitScore(MatchupModel model)
        {
            _administratorService.SubmitScore(model, _context);
            return RedirectToAction("Index");
        }

        public IActionResult StartEvent(int? id)
        {
            return View(_administratorService.StartEvent(id, _context));
        }

        public IActionResult CloseVoting(int? id)
        {
            _administratorService.CloseVoting(id, _context);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditEvent(int? id)
        {
            return View("EventEditView", _context.EventModel.Find(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditEvent(EventModel model)
        {
            await _administratorService.EditEvent(model, _context);
            return RedirectToAction("Index");
        }
    }
}