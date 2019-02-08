using System;

namespace LeagueManagerWebApp.Models
{
    public class MatchupHistoryModel 
    {

        public int Id { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Winner { get; set; }
        public string Loser { get; set; }
        public bool IsFinished { get; set; }
        public DateTime Date { get; set; }
        public int LeagueId { get; set; }
        public int EventId { get; set; }
    }
}
