using Microsoft.AspNetCore.Identity;

namespace LeagueManagerWebApp.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public int Elo { get; set; }
        public int AchievementScore { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int MatchesPlayed { get; set; }
        public string Achievements { get; set; }
        public bool HasVoted { get; set; }
    }
}
