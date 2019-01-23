using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;

namespace LeagueManagerWebApp.Services
{
    public class PlayerService : IPlayerService
    {
        public PlayerViewModel GetPlayerInfo(string Username, List<PlayerModel> list)
        {
            var output = new PlayerViewModel();
            foreach (var elem in list.Where(a => a.Name == Username))
            {
                output.Name = Username;
                output.Elo = elem.Elo;
                output.MatchesPlayed = elem.MatchesPlayed;
                output.MatchesLost = elem.Losses;
                output.MatchesWon = elem.Wins;

            }

            return output;
        }
    }
}
