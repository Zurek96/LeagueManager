using Microsoft.AspNetCore.Mvc;

namespace LeagueManagerWebApp.Controllers
{
    public class EndpointController : Controller
    {
        public IActionResult Index()
        {
            return null;
        }

        public JsonResult EmailCheck()
        {
            return Json("");
        }
    }
}