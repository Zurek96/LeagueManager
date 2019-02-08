using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.ViewModels
{
    public class PlayerViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchesLost { get; set; }
        public int MatchesWon { get; set; }
        public int Draws { get; set; }
        public int Elo { get; set; }
        public List<MatchupHistoryModel> MatchupsHistory { get; set; }

        public PlayerViewModel()
        {
            MatchupsHistory = new List<MatchupHistoryModel>();
        }
    }

    
}
