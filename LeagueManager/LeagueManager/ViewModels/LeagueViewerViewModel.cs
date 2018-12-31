using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using LeagueManager.Abstracts;
using LeagueManager.Context;
using LeagueManager.Models;
using LeagueManager.Views;
using Newtonsoft.Json;

namespace LeagueManager.ViewModels
{
    public class LeagueViewerViewModel : BaseViewModelAbstract
    {
        public static string TurnDate;
        List<MatchupModel> _output = new List<MatchupModel>();
        Dictionary<string, string> _playersDict = new Dictionary<string, string>();
        LeagueManagerContext _context = new LeagueManagerContext();
        List<PlayerModel> _players = new List<PlayerModel>();

        public static double NewElo;

        public string CurrentLeague = MainWindowViewModel.LeagueName;

        public List<PlayerModel> ShowStandings()
        {
            var list = _players;
            list = list.OrderBy(o => o.GamesWon).Reverse().ToList();
            return list;
        }

        public List<PlayerModel> ShowGeneralStandings()
        {
            var list = _players;
            list = list.OrderBy(o => o.Elo).Reverse().ToList();
            return list;
        }

        public void CloseTurn()
        {
            try
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                TurnAggregationModel tmp = new TurnAggregationModel
                {
                    Date = _output[1].MatchDate, WinnerName = ShowStandings()[0].Name
                };
                dict.Add("matchups", "");
                foreach (var elem in _output)
                {
                    dict["matchups"] = dict["matchups"] + ";" + elem.Player1 + "," + elem.Player2 + "," + elem.Winner;
                }

                tmp.Matches = JsonConvert.SerializeObject(dict);
                _context.Turns.Add(tmp);
                
                _output.Clear();
                foreach (var elem in _context.Players.ToList())
                {
                    elem.GeneralGamesWon += elem.GamesWon;
                    elem.GeneralGamesLost += elem.GamesLost;
                    elem.GamesWon = 0;
                    elem.GamesLost = 0;
                }
                _context.SaveChanges();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No matchups!");
            }
        }

        public List<PlayerModel> InitializePlayers()
        {
            foreach (var elem in _context.Leagues.ToList())
            {
                if (elem.Name == CurrentLeague)
                {
                    _playersDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(elem.Competitors);
                }
            }

            var playersString = _playersDict["players"];
            var playersTab = playersString.Split(',');



            foreach (var elem in _context.Players.ToList())
            {

                for (int i = 0; i < playersTab.Length; i++)
                {

                    if (playersTab.Contains(elem.Name))
                    {
                        _players.Add(elem);
                        playersTab[i] = null;
                        break;
                    }
                }
            }
            _playersDict.Clear();
            return _players;
        }

        public List<MatchupModel> GenerateMatchups()
        {
            
            foreach (var player in _players)
            {
                foreach (var player2 in _players)
                {
                    if (player!=player2 && (!(_output.Exists(p => p.Player1 == player.Name && p.Player2 == player2.Name)) &&
                        !(_output.Exists(p => p.Player1 == player2.Name &&  p.Player2 == player.Name))))
                    {
                        MatchupModel tmp = new MatchupModel();
                        tmp.Player1 = player.Name;
                        tmp.Player2 = player2.Name;
                        tmp.IsFinished = false;
                        tmp.MatchDate = DateTime.Now;
                        _output.Add(tmp);
                    }
                }
            }
            return _output;
        }

        public List<MatchupModel> GetFilteredMatchups()
        {
            var outputCopy = _output;
            for (int i = 0; i < _output.Count; i++)
            {
                if (_output[i].IsFinished)
                {
                    outputCopy.Remove(outputCopy[i]);
                }
            }
            return outputCopy;
        }

        public List<string> Seed()
        {

            List<string> output1 = new List<string>();
            foreach (var elem in GetFilteredMatchups())
            {
                var tmp = elem.Player1 + " vs. " + elem.Player2;
                output1.Add(tmp);
            }

            return output1;
        }

        public void DeleteMatchup(string name)
        {
            string player1 = name.Split(' ')[0];
            string player2 = name.Split(' ')[2];

            foreach (var elem in _output)
            {
                if ((elem.Player1 == player1 && elem.Player2 == player2) ||
                    (elem.Player1 == player2 && elem.Player2 == player1))
                {
                    _output.Remove(elem);
                    break;
                }
            }

        }

        public List<MatchupModel> Refresh()
        {
            if (_output.Count != 0)
            {
                return _output;
            }
            else
            {
                return null;
            }
        }

        public List<string> SeedWinner(string name)
        {
            string player1 = name.Split(' ')[0];
            string player2 = name.Split(' ')[2];
            List<string> list = new List<string> {player1, player2};
            return list;
        }

        public void AddWinner(string matchup, string winner)
        {
            string player1 = matchup.Split(' ')[0];
            string player2 = matchup.Split(' ')[2];
            foreach (var elem in _output)
            {
                if ((elem.Player1 == player1 && elem.Player2 == player2) ||
                    (elem.Player1 == player2 && elem.Player2 == player1))
                {
                    elem.Winner = winner;
                    if (winner == player1)
                    {
                        elem.Loser = player2;
                    }

                    if (winner == player2)
                    {
                        elem.Loser = player1;
                    }
                    elem.IsFinished = true;
                    CalculateElo(elem);
                    break;
                }
            }
        }

        public void CalculateElo(MatchupModel matchup)
        {
            PlayerModel winner = new PlayerModel();
            PlayerModel loser = new PlayerModel();
            foreach (var elem in _context.Players.ToList())
            {
                if (elem.Name == matchup.Winner)
                {
                    winner = elem;
                    
                }

                if (elem.Name == matchup.Loser)
                {
                    loser = elem;
                    
                }
            }

            if (winner.Name!=null && loser.Name!=null)
            {
                var S1 = 1;
                var S2 = 0;

                var diff = winner.Elo - loser.Elo;
                var percW = 1 / (1 + Math.Pow(10, diff / 400));
                var percL = 1 / (1 + Math.Pow(10, (loser.Elo - winner.Elo) / 400));

                var K = 32;

                winner.Elo = Math.Floor(winner.Elo + K * (S1 - percW));
                loser.Elo = Math.Floor(loser.Elo + K * (S2 - percL));
            }

            foreach (var elem in _context.Players.ToList())
            {
                if (elem.Name == matchup.Winner)
                {
                    elem.Elo = winner.Elo;
                    elem.GamesWon++;
                }

                if (elem.Name == matchup.Loser)
                {
                    elem.Elo = loser.Elo;
                    elem.GamesLost++;
                }
            }
            _context.SaveChanges();
        }

        public void Closing()
        {
            _players.Clear();
            _output.Clear();
            _playersDict.Clear();
        }

        public void AchCreate()
        {
            AchievementCreator ac = new AchievementCreator();
            ac.Show();
        }

        public void AchDelete(string name)
        {
            foreach (var elem in _context.Achievements.ToList())
            {
                if (elem.Name == name)
                {
                    _context.Achievements.Remove(elem);
                }
            }

            _context.SaveChanges();
            MessageBox.Show("Deleted");
        }

        public void Assign(string ach, string player)
        {
            foreach (var elem in _context.Achievements.ToList())
            {
                if (elem.Name == ach)
                {
                    foreach (var elem2 in _context.Players.ToList())
                    {
                        if (elem2.Name == player)
                        {
                            elem.ListOfPlayers = elem.ListOfPlayers + elem2.Name + " | ";
                            elem2.AchievementScore += elem.Score;
                        }
                    }
                }
            }

            _context.SaveChanges();
            MessageBox.Show("Done!");
        }

        public List<AchievementModel> GetAchList()
        {
            List<AchievementModel> out1 = new List<AchievementModel>();
            foreach (var elem in _context.Achievements.ToList())
            {
                out1.Add(elem);
            }

            return out1;
        }

        public List<string> GetAchNameList()
        {
            List<string> out1 = new List<string>();
            foreach (var elem in _context.Achievements.ToList())
            {
                out1.Add(elem.Name);
            }

            return out1;
        }

        public void TurnDetails(string date)
        {
            TurnDate = date;
            TurnView v = new TurnView();
            v.Show();
        }

        public List<string> GetTurns()
        {
            List<string> output = new List<string>();
            foreach (var elem in _context.Turns.ToList())
            {
                output.Add(elem.Date.ToShortDateString());
            }

            return output;

        }

        public void Absence(string name)
        {
            

            foreach (var elem in _context.Players.ToList())
            {
                if (elem.Name == name)
                {
                    NewElo = elem.Elo * 0.01;
                }
            }

            foreach (var elem in _context.Players.ToList())
            {
             
                if (elem.Name == name)
                {
                    
                    elem.GamesLost += _context.Players.ToList().Count-1;
                    elem.Elo = elem.Elo - (_context.Players.ToList().Count - 1) * NewElo;
                    if (_output.Any())
                    {
                        foreach (var elem2 in _output)
                        {
                            if (elem2.Player1 == name && elem2.IsFinished == false)
                            {
                                elem2.Winner = elem2.Player2;
                                elem2.IsFinished = true;
                                foreach (var player in _context.Players.ToList())
                                {
                                    if (player.Name == elem2.Player2)
                                    {
                                        player.Elo = player.Elo + NewElo;
                                        player.GamesWon++;
                                    }
                                }

                            }
                            if (elem2.Player2 == name && elem2.IsFinished == false)
                            {
                                elem2.Winner = elem2.Player1;
                                elem2.IsFinished = true;
                                foreach (var player in _context.Players.ToList())
                                {
                                    if (player.Name == elem2.Player1)
                                    {
                                        player.Elo = player.Elo + NewElo;
                                        player.GamesWon++;
                                    }
                                }

                            }
                        }
                    }
                }
            }

            _context.SaveChanges();
        }
    }
}
