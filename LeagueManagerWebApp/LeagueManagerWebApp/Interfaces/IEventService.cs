using LeagueManagerWebApp.Data;
using LeagueManagerWebApp.Dto;

namespace LeagueManagerWebApp.Interfaces
{
    public interface IEventService
    {
        bool SubmitVote(VotingDto model, ApplicationDbContext context, string username);
    }
}
