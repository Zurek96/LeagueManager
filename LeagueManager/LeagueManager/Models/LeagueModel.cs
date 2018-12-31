using System;

namespace LeagueManager.Models
{
    public class LeagueModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Competitors { get; set; }
    }
}
