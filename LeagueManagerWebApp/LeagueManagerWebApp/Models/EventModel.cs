using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public VotingModel.Formats Format { get; set; }
        public string Winner { get; set; }
        public string LeagueName { get; set; }
        public bool isFinished { get; set; }
        public DateTime Date { get; set; }
        public string Matchups { get; set; }
    }
}
