using System.Data.Entity;
using LeagueManager.Models;

namespace LeagueManager.Context
{
    public class LeagueManagerContext : DbContext
    {
        public LeagueManagerContext() : base("LeagueManager")
        {

        }

        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<LeagueModel> Leagues { get; set; }
        public DbSet<AchievementModel> Achievements { get; set; }
        public DbSet<TurnAggregationModel> Turns { get; set; }
    }
}
