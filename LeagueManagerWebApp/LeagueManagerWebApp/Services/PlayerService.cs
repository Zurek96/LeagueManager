using System.Collections.Generic;
using System.Linq;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;

namespace LeagueManagerWebApp.Services
{
    public class PlayerService : IPlayerService
    {
        public PlayerViewModel GetPlayerInfo(string username, List<PlayerModel> list, ApplicationDbContext context)
        {
            var output = new PlayerViewModel();
            foreach (var elem in list.Where(a => a.User == username))
            {
                output.Id = elem.Id;
                output.Name = elem.Name;
                output.Elo = elem.Elo;
                output.MatchesPlayed = elem.MatchesPlayed;
                output.MatchesLost = elem.Losses;
                output.MatchesWon = elem.Wins;
            }

            foreach (var elem in context.MatchupHistoryModel.ToList()
                .Where(a => a.Player1 == output.Name || a.Player2 == output.Name))
            {
                output.MatchupsHistory.Add(elem);
            }

            return output;
        }
    }
}
