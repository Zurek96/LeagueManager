using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Format { get; set; }
        public PlayerModel Winner { get; set; }
    }
}
