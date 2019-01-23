using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.ViewModels
{
    public class EventViewModel
    {
        public EventModel Event { get; set; }
        public List<MatchupModel> Matchups { get; set; }
    }
}
