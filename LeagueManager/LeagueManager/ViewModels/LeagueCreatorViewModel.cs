using System;
using System.Collections.Generic;
using System.Windows;
using LeagueManager.Abstracts;
using LeagueManager.Context;
using LeagueManager.Models;
using Newtonsoft.Json;

namespace LeagueManager.ViewModels
{
    public class LeagueCreatorViewModel : BaseViewModelAbstract
    {
        readonly LeagueManagerContext _context = new LeagueManagerContext();
        private string _playersString;

        public void Submit(DateTime startDate,string name)
        {
            LeagueModel league = new LeagueModel();
            Dictionary<string, string> list = new Dictionary<string, string>();
            list.Add("players", _playersString);
            var players = JsonConvert.SerializeObject(list);
            
            league.StartDate = startDate;
            league.Competitors = players;
            league.Name = name;
            _context.Leagues.Add(league);
            _context.SaveChanges();
            MessageBox.Show("League added!");
            
        }

        public void PlayerAdd(string name)
        {
            _playersString = _playersString + "," + name;
        }
    }
}
