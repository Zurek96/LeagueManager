using System.Linq;
using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Dto;
using LeagueManagerWebApp.Interfaces;

namespace LeagueManagerWebApp.Services
{
    public class EventService : IEventService
    {
        public bool SubmitVote(VotingDto model, ApplicationDbContext context, string username)
        {
            var voting = context.VotingModel.Find(model.Id);
            if (!voting.IsOpened) return false;
            if (model.Stand) voting.Stand++;
            if (model.Mod) voting.Mod++;
            if (model.Pau) voting.Pau++;
            if (model.Rain) voting.Rain++;
            if (model.Draft) voting.Draft++;
            if (model.Sing) voting.Sing++;
            if (model.Tri) voting.Tri++;
            if (model.Pea) voting.Pea++;
            if (model.War) voting.War++;
            if (model.Back) voting.Back++;
            context.PlayerModel.First(a => a.User == username).HasVoted =
                true;
            context.VotingModel.Update(voting);
            context.SaveChanges();
            return true;

        }
    }
}
