using System.ComponentModel;

namespace LeagueManagerWebApp.Dto
{
    public class VotingDto
    {
        public int Id { get; set; }
        [DisplayName("Standard")]
        public bool Stand { get; set; }
        [DisplayName("Modern")]
        public bool Mod { get; set; }
        [DisplayName("Pauper")]
        public bool Pau { get; set; }
        [DisplayName("Rainbow")]
        public bool Rain { get; set; }
        [DisplayName("Draft")]
        public bool Draft { get; set; }
        [DisplayName("Singleton")]
        public bool Sing { get; set; }
        [DisplayName("Tribal")]
        public bool Tri { get; set; }
        [DisplayName("Peasant")]
        public bool Pea { get; set; }
        [DisplayName("Warband")]
        public bool War { get; set; }
        [DisplayName("Backdraft")]
        public bool Back { get; set; }
    }
}
