using System.Diagnostics;
using System.Linq;
using LeagueManagerWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;


        public HomeController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
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
