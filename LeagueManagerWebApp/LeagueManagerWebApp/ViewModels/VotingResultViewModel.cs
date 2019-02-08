using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.ViewModels
{
    public class VotingResultViewModel
    {
        public Dictionary<string, int> formats { get; set; }
        public string winner { get; set; }

        public VotingResultViewModel()
        {
            formats = new Dictionary<string, int>();
        }
    }
}
