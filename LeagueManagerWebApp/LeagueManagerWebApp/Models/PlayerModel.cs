namespace LeagueManagerWebApp.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Elo { get; set; }
        public int AchievementScore { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int MatchesPlayed { get; set; }
    }
}
