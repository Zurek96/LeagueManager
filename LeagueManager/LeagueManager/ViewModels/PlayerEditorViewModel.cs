using System;
using System.Linq;
using System.Windows;
using LeagueManager.Context;
using static System.String;

namespace LeagueManager.ViewModels
{
    public class PlayerEditorViewModel
    {
        private readonly LeagueManagerContext _context = new LeagueManagerContext();

        public void Edit(string player, string name, string elo)
        {
            foreach (var elem in _context.Players.ToList())
            {
                if (elem.Name != player) continue;
                if (name != Empty)
                {
                    elem.Name = name;
                }

                if (elo != Empty)
                {
                    elem.Elo = Convert.ToInt32(elo);
                }
            }

            _context.SaveChanges();
            MessageBox.Show("Done");
        }
    }
}
