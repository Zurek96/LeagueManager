using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;
using LeagueManagerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeagueManagerWebApp.Services
{
    public class AdministratorService : IAdministratorService
    {
        public async Task<IActionResult> CreatePlayer(PlayerModel model, ApplicationDbContext context)
        {
            model.Elo = 1600;
            model.AchievementScore = 0;
            model.Losses = 0;
            model.MatchesPlayed = 0;
            model.Wins = 0;
            context.PlayerModel.Add(model);
            await context.SaveChangesAsync();
            return null;
        }

        public async Task<IActionResult> CreateAchievement(AchievementModel model, ApplicationDbContext context)
        {
            context.AchievementModel.Add(model);
            await context.SaveChangesAsync();
            return null;
        }
        public async Task<int> CreateLeague(LeagueModel model, ApplicationDbContext context)
        {
            if (context.PlayerModel.ToList().Count == 1)
            {
                return 1;
            }
            context.LeagueModel.Add(model);
            await context.SaveChangesAsync();
            return 0;
        }
        public async Task<IActionResult> EditPlayer(PlayerModel model, ApplicationDbContext context)
        {
            var original = context.PlayerModel.Find(model.Id);
            if (model.Elo != original.Elo && model.Elo != 0)
            {
                original.Elo = model.Elo;
            }
            if (model.MatchesPlayed != original.MatchesPlayed && model.MatchesPlayed != 0)
            {
                original.MatchesPlayed = model.MatchesPlayed;
            }
            if (model.Wins != original.Wins && model.Wins != 0)
            {
                original.Wins = model.Wins;
            }
            if (model.Losses != original.Losses && model.Losses != 0)
            {
                original.Losses = model.Losses;
            }
            if (model.HasVoted != original.HasVoted)
            {
                original.HasVoted = model.HasVoted;
            }


            context.PlayerModel.Update(original);
            await context.SaveChangesAsync();
            return null;
        }
        public async Task<IActionResult> EditAchievement(AchievementModel model, ApplicationDbContext context)
        {
            var original = context.AchievementModel.Find(model.Id);
            if (model.Points != original.Points && model.Points != 0)
            {
                original.Points = model.Points;
            }
            if (model.Description != original.Description && model.Description != null)
            {
                original.Description = model.Description;
            }
            context.AchievementModel.Update(original);
            await context.SaveChangesAsync();
            return null;
        }
        public async Task<IActionResult> EditLeague(LeagueModel model, ApplicationDbContext context)
        {
            var original = context.LeagueModel.Find(model.Id);
            if (model.Players != original.Players && model.Players != null)
            {
                original.Players = model.Players;
            }
            context.LeagueModel.Update(original);
            await context.SaveChangesAsync();
            return null;
        }
        public IActionResult DeletePlayer(int? id, ApplicationDbContext context)
        {
            var model = context.PlayerModel.Find(id);
            context.PlayerModel.Remove(model);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(PlayerModel, RESEED, " + context.PlayerModel.ToList().Count + ")");
            context.SaveChanges();
            return null;
        }
        public IActionResult DeleteLeague(int? id, ApplicationDbContext context)
        {
            var model = context.LeagueModel.Find(id);
            var matchups = context.MatchupModel.ToList();
            foreach (var elem in matchups.Where(a => a.LeagueId == model.Id))
            {
                context.MatchupModel.Remove(elem);
            }
            context.LeagueModel.Remove(model);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(LeagueModel, RESEED, " + context.LeagueModel.ToList().Count + ")");
            context.SaveChanges();
            return null;
        }
        public IActionResult DeleteAchievement(int? id, ApplicationDbContext context)
        {
            var model = context.AchievementModel.Find(id);
            context.AchievementModel.Remove(model);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(AchievementModel, RESEED, " + context.AchievementModel.ToList().Count + ")");
            context.SaveChanges();
            return null;
        }
        public IActionResult DeleteEvent(int? id, ApplicationDbContext context)
        {
            var model = context.EventModel.Find(id);
            context.EventModel.Remove(model);
            foreach (var elem in context.VotingModel.ToList().Where(a => a.Event == model))
            {
                context.VotingModel.Remove(elem);
            }
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(VotingModel, RESEED, "+context.VotingModel.ToList().Count+")");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(EventModel, RESEED, "+context.EventModel.ToList().Count + ")");

            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(MatchupModel, RESEED, " + context.MatchupModel.ToList().Count + ")");
            foreach (var elem in context.PlayerModel.ToList())
            {
                elem.HasVoted = false;
            }
            context.SaveChanges();
            return null;
        }
        public IActionResult StartLeague(LeagueModel model, ApplicationDbContext context)
        {
            var starter = context.LeagueModel.ToList().First(a => a.Name == model.Name);
            var playersSplit = starter.Players.Split(',');
            List<MatchupModel> matchup = new List<MatchupModel>();
            List<PlayerModel> players = new List<PlayerModel>();
            foreach (var elem in playersSplit)
            {
                foreach (var player in context.PlayerModel.ToList().Where(a => a.Name == elem))
                {
                    players.Add(player);
                }
            }
            var Event = new EventModel();
            DateTime today = DateTime.Today;
            int daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)today.DayOfWeek + 7) % 7;
            Event.Date = today.AddDays(daysUntilTuesday);

            Event.Format = VotingModel.Formats.Standard;
            Event.LeagueId = starter.Id;
            Event.isFinished = false;

            var voting = new VotingModel();
            voting.Event = Event;
            voting.IsOpened = true;

            context.VotingModel.Add(voting);

            context.EventModel.Add(Event);

            context.SaveChanges();

            return null;
        }
        public IActionResult SubmitScore(MatchupModel model, ApplicationDbContext context)
        {
            var S1 = 1;
            var S2 = 0;
            PlayerModel player1 = context.PlayerModel.First(a => a.Name == model.Player1);
            PlayerModel player2 = context.PlayerModel.First(a => a.Name == model.Player2);
            if (model.Winner == model.Player1)
            {
                model.Loser = model.Player2;
                player1.MatchesPlayed++;
                player2.MatchesPlayed++;
                player2.Losses++;
                player1.Wins++;
                var diff = player1.Elo - player2.Elo;
                var percW = 1 / (1 + Math.Pow(10, diff / 400));
                var percL = 1 / (1 + Math.Pow(10, (player2.Elo - player1.Elo) / 400));
                var k = 32;

                player1.Elo = (int)Math.Floor(player1.Elo + k * (S1 - percW));
                player2.Elo = (int)Math.Floor(player2.Elo + k * (S2 - percL));
            }
            else
            {
                model.Loser = model.Player1;
                player1.MatchesPlayed++;
                player2.MatchesPlayed++;
                player1.Losses++;
                player2.Wins++;
                var diff = player2.Elo - player1.Elo;
                var percW = 1 / (1 + Math.Pow(10, diff / 400));
                var percL = 1 / (1 + Math.Pow(10, (player1.Elo - player2.Elo) / 400));
                var k = 32;

                player2.Elo = (int)Math.Floor(player2.Elo + k * (S1 - percW));
                player1.Elo = (int)Math.Floor(player1.Elo + k * (S2 - percL));
            }

            model.Date = context.EventModel.Find(model.EventId).Date;
            model.IsFinished = true;
            MatchupHistoryModel histmodel = new MatchupHistoryModel();
            histmodel.Player1 = model.Player1;
            histmodel.Player2 = model.Player2;
            histmodel.Winner = model.Winner;
            histmodel.Loser = model.Loser;
            histmodel.LeagueId = model.LeagueId;
            context.MatchupHistoryModel.Add(histmodel);

            context.PlayerModel.Update(player1);
            context.PlayerModel.Update(player2);

            context.MatchupModel.Update(model);
            context.SaveChanges();
            if (!context.MatchupModel.ToList().Exists(a => a.LeagueId == model.LeagueId && a.IsFinished))
            {
                var b = context.EventModel.First(a => a.LeagueId == model.LeagueId);
                b.isFinished = true;
                context.EventModel.Update(b);
                context.SaveChanges();
            }

            return null;
        }
        public EventViewModel StartEvent(int? id, ApplicationDbContext context)
        {
            var viewModel = new EventViewModel();
            var model = context.EventModel.Find(id);
            var league = context.LeagueModel.First(a => a.Id == model.LeagueId);
            foreach (var elem in league.Players.Split(','))
            {
                viewModel.Players.Add(context.PlayerModel.First(a=>a.Name==elem));
            }
            viewModel.Event = model;
            return viewModel;
        }
        public IActionResult CloseVoting(int? id, ApplicationDbContext context)
        {
            var Event = context.EventModel.Find(id);
            var voting = new VotingModel();
            foreach (var elem in context.VotingModel.ToList().Where(a => a.Event == Event))
            {
                voting = elem;
            }

            if (voting.IsOpened)
            {
                voting.IsOpened = false;
                Dictionary<VotingModel.Formats, int> results = new Dictionary<VotingModel.Formats, int>();
                results.Add(VotingModel.Formats.Standard, voting.Stand);
                results.Add(VotingModel.Formats.Modern, voting.Mod);
                results.Add(VotingModel.Formats.Pauper, voting.Pau);
                results.Add(VotingModel.Formats.Rainbow, voting.Rain);
                results.Add(VotingModel.Formats.Draft, voting.Draft);
                results.Add(VotingModel.Formats.Singleton, voting.Sing);
                results.Add(VotingModel.Formats.Tribal, voting.Tri);
                results.Add(VotingModel.Formats.Peasant, voting.Pea);
                results.Add(VotingModel.Formats.Warband, voting.War);
                results.Add(VotingModel.Formats.Backdraft, voting.Back);

                Event.Format = results.Keys.First();

                foreach (var elem in results)
                {
                    if (elem.Value > results[Event.Format])
                    {
                        Event.Format = elem.Key;
                    }
                }

                voting.IsOpened = false;
                context.VotingModel.Update(voting);
                context.EventModel.Update(Event);
                context.SaveChanges();

            }

            return null;
        }    }
}
