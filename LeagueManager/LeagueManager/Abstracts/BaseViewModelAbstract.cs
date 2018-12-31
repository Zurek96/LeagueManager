using System.Collections.Generic;
using System.Linq;
using LeagueManager.Context;

namespace LeagueManager.Abstracts
{
    public abstract class BaseViewModelAbstract
    {
        public List<string> RefreshPlayers(LeagueManagerContext context)
        {
            List<string> output = new List<string>();
            foreach (var elem in context.Players.ToList())
            {
                output.Add(elem.Name);
            }

            return output;
        }

    }
}
