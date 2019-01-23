using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.ViewModels
{
    public class AchievementsViewModel
    {
        public List<PlayerModel> Players { get; set; }
        public List<AchievementModel> Achievements { get; set; }
    }
}
