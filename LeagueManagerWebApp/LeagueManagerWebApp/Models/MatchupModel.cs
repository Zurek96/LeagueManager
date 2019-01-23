using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Winner { get; set; }
        public string Loser { get; set; }
        public bool IsFinished { get; set; }
        public DateTime Date { get; set; }
        public LeagueModel League { get; set; }
    }
}
