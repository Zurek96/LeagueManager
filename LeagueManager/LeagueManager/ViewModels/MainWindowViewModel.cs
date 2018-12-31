using System.Collections.Generic;
using System.Linq;
using System.Windows;
using LeagueManager.Context;
using LeagueManager.Models;
using LeagueManager.Views;
using Prism.Mvvm;

namespace LeagueManager.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public static string LeagueName;
        readonly LeagueManagerContext _context = new LeagueManagerContext();

        public void LoadLeague(string name)
        {
            foreach (var elem in _context.Leagues.ToList())
            {
                if (elem.Name == name)
                {
                    LeagueName = elem.Name;
                }
            }
            LeagueView lv = new LeagueView();
            lv.Show();
        }

        public void CreateLeague()
        {
            LeagueCreator lc = new LeagueCreator();
            lc.Show();
        }

        public List<string> Refresh()
        {
            List<LeagueModel> list = _context.Leagues.ToList();
            List<string> drop = new List<string>();
            foreach (var elem in list)
            {
                drop.Add(elem.Name);
            }

            return drop;
        }

        public void DeleteLeague(string name)
        {
            foreach (var elem in _context.Leagues.ToList())
            {
                if (elem.Name == name)
                {
                    _context.Leagues.Remove(elem);
                }
            }

            _context.SaveChanges();
            MessageBox.Show("League deleted!");
        }

        public void PlayerCreator()
        {
            PlayerCreator pc = new PlayerCreator();
            pc.Show();
        }

        public List<string> RefreshPlayers()
        {
            List<string> output = new List<string>();
            foreach (var elem in _context.Players.ToList())
            {
                output.Add(elem.Name);
            }

            return output;
        }

        public void DeletePlayer(string name)
        {
            foreach (var elem in _context.Players.ToList())
            {
                if (elem.Name == name)
                {
                    _context.Players.Remove(elem);
                }
            }

            _context.SaveChanges();
            MessageBox.Show("Player deleted!");
        }

        public void ClearAll()
        {
            _context.Database.ExecuteSqlCommand("Truncate Table PlayerModels");
            _context.Database.ExecuteSqlCommand("Truncate Table LeagueModels");
            _context.Database.ExecuteSqlCommand("Truncate Table AchievementModels");
            _context.Database.ExecuteSqlCommand("Truncate Table TurnAggregationModels");
        }
    }
}
