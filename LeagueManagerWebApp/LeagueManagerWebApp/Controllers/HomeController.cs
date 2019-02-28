using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHomeService _homeService;

        public HomeController(ApplicationDbContext context, IHomeService homeService)
        {
            _homeService = homeService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(await _homeService.RandomCard());
            }

            return Redirect("/Identity/Account/Login");
        }

        public IActionResult Rules()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Formats()
        {
            ViewData["Message"] = "Your contact page.";

            return View(_context.FormatDescriptionModel.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}