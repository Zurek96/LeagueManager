using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.ViewModels
{
    public class ScoreViewModel
    {
        public List<MatchupModel> Matchups { get; set; }
        public List<PlayerViewModel> Players { get; set; }
        public List<LeagueModel> Leagues { get; set; }

        public ScoreViewModel(List<MatchupModel> matchups, List<LeagueModel> leagues)
        {
            Matchups = matchups;
            Leagues = leagues;
        }
    }

    
}
