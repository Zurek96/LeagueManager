using System;

namespace LeagueManager.Models
{
    public class TurnAggregationModel
    {
        public int Id { get; set; }
        public string WinnerName { get; set; }
        public string Matches { get; set; }
        public DateTime Date { get; set; }
    }
}
