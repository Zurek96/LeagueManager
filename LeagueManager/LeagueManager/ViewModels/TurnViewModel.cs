using System.Collections.Generic;
using System.Linq;
using LeagueManager.Context;
using LeagueManager.Models;
using Newtonsoft.Json;

namespace LeagueManager.ViewModels
{
    public class TurnViewModel
    {
        private readonly LeagueManagerContext _context = new LeagueManagerContext();

        public List<MatchupModel> ReadMatchups(string date)
        {
            var output = new List<MatchupModel>();
            var turn = new TurnAggregationModel();
            foreach (var elem in _context.Turns.ToList())
            {
                if (elem.Date.ToShortDateString() == date)
                {
                    turn = elem;
                }
            }

            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(turn.Matches);
            var split = dict["matchups"].Split(';');
            foreach (var elem in split)
            {
                var matchup = elem.Split(',');
                if (elem != "")
                {
                    MatchupModel tmp = new MatchupModel
                    {
                        Player1 = matchup[0], Player2 = matchup[1], Winner = matchup[2]
                    };
                    output.Add(tmp);
                }
            }

            return output;
        }
    }
}
