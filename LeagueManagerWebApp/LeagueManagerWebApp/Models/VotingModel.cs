using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Models
{
    public class VotingModel
    {
        public int Id { get; set; }
        public bool IsOpened { get; set; }
        public string Winner { get; set; }
        public EventModel Event { get; set; }

        [DisplayName("Standard")]
        public int Stand { get; set; }
        [DisplayName("Modern")]
        public int Mod { get; set; }
        [DisplayName("Pauper")]
        public int Pau { get; set; }
        [DisplayName("Rainbow")]
        public int Rain { get; set; }
        [DisplayName("Draft")]
        public int Draft { get; set; }
        [DisplayName("Singleton")]
        public int Sing { get; set; }
        [DisplayName("Tribal")]
        public int Tri { get; set; }
        [DisplayName("Peasant")]
        public int Pea { get; set; }
        [DisplayName("Warband")]
        public int War { get; set; }
        [DisplayName("Backdraft")]
        public int Back { get; set; }

        public enum Formats
        {
            Standard,
            Modern,
            Pauper,
            Rainbow,
            Draft,
            Singleton,
            Tribal,
            Peasant,
            Warband,
            Backdraft
        }
    }
}
