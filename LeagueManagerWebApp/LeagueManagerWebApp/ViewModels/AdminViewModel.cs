using System.Collections.Generic;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.ViewModels
{
    public class AdminViewModel
    {
        public List<PlayerModel> PlayerList { get; set; }
        public List<AchievementModel> AchievementList { get; set; }
        public List<LeagueModel> LeagueList { get; set; }
        public List<EventModel> EventsList { get; set; }

        public AdminViewModel()
        {
            var tmpPl = new PlayerModel();
            var tmpAc = new AchievementModel();
            var tmpLe = new LeagueModel();
            var tmpEv = new EventModel();
            EventsList = new List<EventModel>();
            PlayerList = new List<PlayerModel>();
            AchievementList = new List<AchievementModel>();
            LeagueList = new List<LeagueModel>();
            PlayerList.Add(tmpPl);
            AchievementList.Add(tmpAc);
            LeagueList.Add(tmpLe);
            EventsList.Add(tmpEv);
        }
    }

    
}
