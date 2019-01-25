using System.Threading.Tasks;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LeagueManagerWebApp.Interfaces
{
    public interface IAdministratorService
    {
        Task<IActionResult> CreatePlayer(PlayerModel model, ApplicationDbContext context);
        Task<IActionResult> CreateAchievement(AchievementModel model, ApplicationDbContext context);
        Task<int> CreateLeague(LeagueModel model, ApplicationDbContext context);
        Task<IActionResult> EditPlayer(PlayerModel model, ApplicationDbContext context);
        Task<IActionResult> EditAchievement(AchievementModel model, ApplicationDbContext context);
        Task<IActionResult> EditLeague(LeagueModel model, ApplicationDbContext context);
        IActionResult DeletePlayer(int? id, ApplicationDbContext context);
        IActionResult DeleteLeague(int? id, ApplicationDbContext context);
        IActionResult DeleteAchievement(int? id, ApplicationDbContext context);
        IActionResult DeleteEvent(int? id, ApplicationDbContext context);
        IActionResult StartLeague(LeagueModel model, ApplicationDbContext context);
        IActionResult SubmitScore(MatchupModel model, ApplicationDbContext context);
        EventViewModel StartEvent(int? id, ApplicationDbContext context);
        IActionResult CloseVoting(int? id, ApplicationDbContext context);
    }
}
