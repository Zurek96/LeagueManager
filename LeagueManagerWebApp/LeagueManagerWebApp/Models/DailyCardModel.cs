namespace LeagueManagerWebApp.Models
{
    public class DailyCardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string ImgPath { get; set; }
        public string TCGpath { get; set; }
        public string CMpath { get; set; }
        public string CHpath { get; set; }
        public string price { get; set; }
        public string deckPath { get; set; }
    }
}