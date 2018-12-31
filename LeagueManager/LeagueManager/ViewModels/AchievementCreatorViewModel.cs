using System.Windows;
using LeagueManager.Context;
using LeagueManager.Models;

namespace LeagueManager.ViewModels
{
    public class AchievementCreatorViewModel
    {
        readonly LeagueManagerContext _context = new LeagueManagerContext();

        public void AddPlayer(string name, int score, string desc)
        {
            AchievementModel model = new AchievementModel {Name = name, Score = score, Description = desc};
            _context.Achievements.Add(model);
            _context.SaveChanges();
            MessageBox.Show("Added!");
        }

    }
}
