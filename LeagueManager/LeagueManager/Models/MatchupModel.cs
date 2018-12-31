using System;

namespace LeagueManager.Models
{
    public class MatchupModel
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public bool IsFinished { get; set; }
        public string Winner { get; set; }
        public string Loser { get; set; }
        public DateTime MatchDate { get; set; }
    }
}
