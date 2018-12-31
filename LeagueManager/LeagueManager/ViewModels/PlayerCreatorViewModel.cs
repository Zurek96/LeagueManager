using System.Windows;
using LeagueManager.Context;
using LeagueManager.Models;
using Prism.Mvvm;

namespace LeagueManager.ViewModels
{
    public class PlayerCreatorViewModel : BindableBase
    {
        readonly LeagueManagerContext _context = new LeagueManagerContext();

        public void AddPlayer(string name)
        {
            PlayerModel tmp = new PlayerModel {Name = name, Elo = 1600};
            _context.Players.Add(tmp);
            _context.SaveChanges();
            MessageBox.Show("Added Player: " + name);
        }
    }
}
