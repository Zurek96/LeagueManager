using LeagueManagerWebApp.Models;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Interfaces
{
    public interface IHomeService
    {
        Task<DailyCardModel> RandomCard();
    }
}