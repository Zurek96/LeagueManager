using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Models
{
    public class FormatsDescriptionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeckSize { get; set; }
        public string Description { get; set; }
    }
}
