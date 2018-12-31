namespace LeagueManager.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Elo { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public int GeneralGamesWon { get; set; }
        public int GeneralGamesLost { get; set; }
        public int AchievementScore { get; set; }
    }
}
