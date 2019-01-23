using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;

namespace LeagueManagerWebApp.Interfaces
{
    public interface IPlayerService
    {
        PlayerViewModel GetPlayerInfo(string Username, List<PlayerModel> list);
    }
}
