using System.Collections.Generic;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;

namespace LeagueManagerWebApp.Interfaces
{
    public interface IPlayerService
    {
        PlayerViewModel GetPlayerInfo(string username, List<PlayerModel> list, ApplicationDbContext context);
    }
}
