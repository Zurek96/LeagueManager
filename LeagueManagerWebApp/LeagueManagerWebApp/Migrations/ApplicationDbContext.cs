using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeagueManagerWebApp.Models;

namespace LeagueManagerWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LeagueManagerWebApp.Models.PlayerModel> PlayerModel { get; set; }
        public DbSet<LeagueManagerWebApp.Models.EventModel> EventModel { get; set; }
        public DbSet<LeagueManagerWebApp.Models.LeagueModel> LeagueModel { get; set; }
        public DbSet<LeagueManagerWebApp.Models.MatchupModel> MatchupModel { get; set; }
        public DbSet<LeagueManagerWebApp.Models.AchievementModel> AchievementModel { get; set; }
        public DbSet<LeagueManagerWebApp.Models.VotingModel> VotingModel { get; set; }
        public DbSet<LeagueManagerWebApp.Models.MatchupHistoryModel> MatchupHistoryModel { get; set; }
        public DbSet<LeagueManagerWebApp.Models.FormatsDescriptionModel> FormatDescriptionModel { get; set; }
    }
}
